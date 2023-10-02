using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Cryptology
{
    public partial class SimpleSubstitutionCipherForm : Form
    {
        MainForm mainForm;
        Dictionary<char, char> dictionaryWithCipher;

        #region Variables for resize and resize realization
        private Size formOriginalSize;
        private Rectangle rectextBoxShowText;
        private Rectangle reclistView1;
        private Rectangle recmakeRandomTable;
        private Rectangle recloadTableToFile;
        private Rectangle recloadTextToFile;
        private Rectangle recdecipherText;
        private Rectangle recButtonToOpenMainForm;
        private Rectangle recloadTableFromFile;
        private Rectangle recbuttonToLoadText;
        private Rectangle reccipherText;
        private Rectangle recreset;

        private void ConstructioOfFrequencyTablesForm_Resiz(object sender, EventArgs e)
        {
            MainForm.resize_Control(this, formOriginalSize, textBoxShowText, rectextBoxShowText);
            MainForm.resize_Control(this, formOriginalSize, listView1, reclistView1);
            MainForm.resize_Control(this, formOriginalSize, makeRandomTable, recmakeRandomTable);
            MainForm.resize_Control(this, formOriginalSize, loadTableToFile, recloadTableToFile);
            MainForm.resize_Control(this, formOriginalSize, loadTextToFile, recloadTextToFile);
            MainForm.resize_Control(this, formOriginalSize, decipherText, recdecipherText);
            MainForm.resize_Control(this, formOriginalSize, ButtonToOpenMainForm, recButtonToOpenMainForm);
            MainForm.resize_Control(this, formOriginalSize, loadTableFromFile, recloadTableFromFile);
            MainForm.resize_Control(this, formOriginalSize, buttonToLoadText, recbuttonToLoadText);
            MainForm.resize_Control(this, formOriginalSize, cipherText, reccipherText);
            MainForm.resize_Control(this, formOriginalSize, reset, recreset);
        }
        #endregion

        public SimpleSubstitutionCipherForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            dictionaryWithCipher = new Dictionary<char, char>();

            #region Initializate variables for resize
            this.Resize += ConstructioOfFrequencyTablesForm_Resiz;
            formOriginalSize = this.Size;
            rectextBoxShowText = new Rectangle(textBoxShowText.Location, textBoxShowText.Size);
            reclistView1 = new Rectangle(listView1.Location, listView1.Size);
            recmakeRandomTable = new Rectangle(makeRandomTable.Location, makeRandomTable.Size);
            recloadTableToFile = new Rectangle(loadTableToFile.Location, loadTableToFile.Size);
            recloadTextToFile = new Rectangle(loadTextToFile.Location, loadTextToFile.Size);
            recdecipherText = new Rectangle(decipherText.Location, decipherText.Size);
            recButtonToOpenMainForm = new Rectangle(ButtonToOpenMainForm.Location, ButtonToOpenMainForm.Size);
            recloadTableFromFile = new Rectangle(loadTableFromFile.Location, loadTableFromFile.Size);
            recbuttonToLoadText = new Rectangle(buttonToLoadText.Location, buttonToLoadText.Size);
            reccipherText = new Rectangle(cipherText.Location, cipherText.Size);
            recreset = new Rectangle(reset.Location, reset.Size);
            #endregion
        }

        private void closeThisForm(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void ButtonToOpenMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void makeTable()
        {
            listView1.Items.Clear();

            // Loop through each dictionary entry and create a list view item with the character and its frequency
            foreach (var dic in dictionaryWithCipher)
            {
                ListViewItem item = new ListViewItem(dic.Key.ToString());
                item.SubItems.Add(dic.Value.ToString());
                listView1.Items.Add(item);
            }
        }

        private void makeRandomTable_Click(object sender, EventArgs e)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random rand = new Random();
            char[] shuffledArray = chars.OrderBy(x => rand.Next()).ToArray();
            dictionaryWithCipher = new Dictionary<char, char>();
            for (int iterator = 0; iterator < chars.Length; iterator++)
            {
                dictionaryWithCipher.Add(chars[iterator], shuffledArray[iterator]);
            }
            makeTable();
        }

        private void loadTableFromFile_Click(object sender, EventArgs e)
        {
            string fileName = MainForm.openFileDialogToLoadFile();
            if (fileName == null)
                return;

            dictionaryWithCipher = new Dictionary<char, char>();
            // Open a StreamReader to read the file line by line.
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Continue reading the file until the end of the stream is reached.
                while (!reader.EndOfStream)
                {
                    // Read a line from the file and split it into separate values based on the '.' delimiter.
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    char[] charsOne = values[0].ToCharArray();
                    char[] charsTwo = values[1].ToCharArray();

                    try { dictionaryWithCipher.Add(charsOne[0], charsTwo[0]); }
                    catch
                    {
                        MessageBox.Show("You have chose file with not valiable data, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            makeTable();
        }

        private void loadTableToFile_Click(object sender, EventArgs e)
        {
            string fileName = MainForm.openFileDialogToLoadFile();
            if (fileName == null)
                return;

            // Create a StreamWriter instance to write the table to the file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var dictionary in dictionaryWithCipher)
                {
                    writer.Write(dictionary.Key.ToString());
                    writer.Write(",");
                    writer.Write(dictionary.Value.ToString());
                    writer.WriteLine();
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            dictionaryWithCipher = new Dictionary<char, char>();
            textBoxShowText.Text = "You have add no text. To add text press \"Chose file, to read the data.\" button.";
        }

        private void buttonToLoadText_Click(object sender, EventArgs e)
        {
            readDataAndFillItInMessageBox();
        }

        private void readDataAndFillItInMessageBox()
        {
            string fileName = MainForm.openFileDialogToLoadFile();
            if (fileName == null)
                return;

            string text = File.ReadAllText(fileName);

            textBoxShowText.Text = text;
            textBoxShowText.ScrollBars = ScrollBars.Both;
        }

        private string changeText()
        {
            while (true)
            {
                // If the textbox is empty or has a default message, prompt the user to add text
                if (string.IsNullOrEmpty(textBoxShowText.Text)
                    || textBoxShowText.Text == "You have add no text. To add text press \"Chose file, to read the data.\" button."
                    || textBoxShowText.Text == "Plese, before making any operations load text. You have add no text. To add text press \"Chose file, to read the data.\" button.")
                {
                    MessageBox.Show("Plese add some text, before any actions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxShowText.Text = "Plese, before making any operations load text. You have add no text. To add text press \"Chose file, to read the data.\" button.";
                    readDataAndFillItInMessageBox();
                }
                else
                {
                    // Replace all non-letter characters with an empty string and make the text lowercase
                    Regex regex = new Regex("[^a-z]");
                    string textToLover = textBoxShowText.Text.ToLower();
                    return regex.Replace(textToLover, "");
                }
            }
        }

        private void cipherText_Click(object sender, EventArgs e)
        {
            if (dictionaryWithCipher.Count == 0)
            {
                MessageBox.Show("You have no table for cipher. Plese before chose it. You can load already made table or generate random.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string text = changeText();
            textBoxShowText.Text = new string(text.Select(character => dictionaryWithCipher.ContainsKey(character) ? dictionaryWithCipher[character] : character).ToArray());
        }

        private void decipherText_Click(object sender, EventArgs e)
        {
            if (dictionaryWithCipher.Count == 0)
            {
                MessageBox.Show("You have no table for decipher. Plese before chose it. You can load already made table or generate random.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string textToRemake = textBoxShowText.Text;
            textBoxShowText.Text = new string(textToRemake.Select(character => dictionaryWithCipher.ContainsValue(character) ? dictionaryWithCipher.FirstOrDefault(x => x.Value == character).Key : character).ToArray());
        }

        private void loadTextToFile_Click(object sender, EventArgs e)
        {
            string filePath = MainForm.openFileDialogToLoadFile();
            if (filePath == null)
                return;

            // Create a StreamWriter instance to write the table to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(textBoxShowText.Text);
            }
        }
    }
}

