using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Cryptology
{
    public partial class DecipheringByFrequencyAnalysisForm : Form
    {
        MainForm mainForm;
        Dictionary<char, double> templateTable;
        Dictionary<char, double> frequencyTable;
        Dictionary<char, char> letterToLetter;
        string textToDecipher = "";

        #region Variables for resize and resize realization
        private Size formOriginalSize;
        private Rectangle rectextBoxShowText;
        private Rectangle reclistView1;
        private Rectangle recLoadTextToDecipher;
        private Rectangle recDecipher;
        private Rectangle recLoadTextToFile;
        private Rectangle recLoadTableToFile;
        private Rectangle recLoadTableFromFile;
        private Rectangle recReset;
        private Rectangle recChangeLetters;
        private Rectangle recMainForm;

        private void ConstructioOfFrequencyTablesForm_Resiz(object sender, EventArgs e)
        {
            MainForm.resize_Control(this, formOriginalSize, TextBoxWithData, rectextBoxShowText);
            MainForm.resize_Control(this, formOriginalSize, listView1, reclistView1);
            MainForm.resize_Control(this, formOriginalSize, loadTextForDecipher, recLoadTextToDecipher);
            MainForm.resize_Control(this, formOriginalSize, ButtonToDecipher, recDecipher);
            MainForm.resize_Control(this, formOriginalSize, loadTextToFile, recLoadTextToFile);
            MainForm.resize_Control(this, formOriginalSize, LoadTableToFile, recLoadTableToFile);
            MainForm.resize_Control(this, formOriginalSize, LoadTableFromFile, recLoadTableFromFile);
            MainForm.resize_Control(this, formOriginalSize, Reset, recReset);
            MainForm.resize_Control(this, formOriginalSize, changeLetters, recChangeLetters);
            MainForm.resize_Control(this, formOriginalSize, ButtonToOpenMainForm, recMainForm);
        }
        #endregion

        public DecipheringByFrequencyAnalysisForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            LoadTableFromFileToTemplateFrequency();
            templateTable = new Dictionary<char, double>();
            frequencyTable = new Dictionary<char, double>();
            letterToLetter = new Dictionary<char, char>();

            #region Initializate variables for resize
            this.Resize += ConstructioOfFrequencyTablesForm_Resiz;
            formOriginalSize = this.Size;
            rectextBoxShowText = new Rectangle(TextBoxWithData.Location, TextBoxWithData.Size);
            reclistView1 = new Rectangle(listView1.Location, listView1.Size);
            recLoadTextToDecipher = new Rectangle(loadTextForDecipher.Location, loadTextForDecipher.Size);
            recDecipher = new Rectangle(ButtonToDecipher.Location, ButtonToDecipher.Size);
            recLoadTextToFile = new Rectangle(loadTextToFile.Location, loadTextToFile.Size);
            recLoadTableToFile = new Rectangle(LoadTableToFile.Location, LoadTableToFile.Size);
            recLoadTableFromFile = new Rectangle(LoadTableFromFile.Location, LoadTableFromFile.Size);
            recReset = new Rectangle(Reset.Location, Reset.Size);
            recChangeLetters = new Rectangle(changeLetters.Location, changeLetters.Size);
            recMainForm = new Rectangle(ButtonToOpenMainForm.Location, ButtonToOpenMainForm.Size);
            #endregion
        }

        private void ButtonToOpenMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeThisForm(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void loadTextForDecipher_Click(object sender, EventArgs e)
        {
            string fileName = MainForm.openFileDialogToLoadFile();
            if (fileName == null)
                return;

            string text = File.ReadAllText(fileName);

            textToDecipher = text;
            TextBoxWithData.Text = text;
            TextBoxWithData.ScrollBars = ScrollBars.Both;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            TextBoxWithData.Text = "You have add no text. To add text press \"Chose file, to read the data.\" button.";

            frequencyTable.Clear();
            letterToLetter.Clear();
        }

        private void LoadTableFromFileToTemplateFrequency()
        {
            string fileName = "C:\\Users\\asd\\source\\C#\\University\\Cryptology\\Cryptology\\TxtForAllHomeworks\\thirdTask\\TableForThirsTaks.txt";

            templateTable = new Dictionary<char, double>();
            // Open a StreamReader to read the file line by line.
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Continue reading the file until the end of the stream is reached.
                while (!reader.EndOfStream)
                {
                    // Read a line from the file and split it into separate values based on the '.' delimiter.
                    string line = reader.ReadLine();
                    string[] values = line.Split(' ');

                    // Create a new ListViewItem with the first value as the text and the second value as a subitem.
                    ListViewItem item = new ListViewItem(values[0]);
                    double value = 0;

                    // Try to parse the second value as a double and add it as a subitem if successful.
                    double.TryParse(values[1], out value);

                    // Add the ListViewItem to the ListView control.
                    templateTable.Add(values[0].ToArray()[0], value);
                }
            }
        }

        private string changeText()
        {
            // If the textbox is empty or has a default message, prompt the user to add text
            if (string.IsNullOrEmpty(TextBoxWithData.Text)
                || TextBoxWithData.Text == "You have add no text. To add text press \"Chose file, to read the data.\" button."
                || TextBoxWithData.Text == "Plese, before making any operations load text. You have add no text. To add text press \"Chose file, to read the data.\" button.")
            {
                MessageBox.Show("Plese add some text, before any actions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxWithData.Text = "Plese, before making any operations load text. You have add no text. To add text press \"Chose file, to read the data.\" button.";
                return null;
            }
            else
            {
                // Replace all non-letter characters with an empty string and make the text lowercase
                Regex regex = new Regex("[^a-z]");
                TextBoxWithData.Text.ToLower();
                string textToLover = TextBoxWithData.Text.ToLower();
                return regex.Replace(textToLover, "");
            }
        }

        private void MakeTableOffLetterOfTextFrequency()
        {
            frequencyTable = new Dictionary<char, double>();
            // Get the text with only letters
            string standardizedText = changeText();

            // Count the number of letters in the text
            int length = standardizedText.Length;

            // Group the letters and count their frequency
            frequencyTable = standardizedText.GroupBy(letter => letter).ToDictionary(element => element.Key, element => element.Count() / Convert.ToDouble(length));

            if (frequencyTable.Count != 26)
            {
                for (char c = 'a'; c <= 'z'; c++)
                {
                    // check if the dictionary contains the current letter
                    if (!frequencyTable.ContainsKey(c))
                    {
                        // if the letter is not in the dictionary, add it with a value of 0.0
                        frequencyTable.Add(c, 0.0);
                    }
                }
            }
        }

        private void makeLetterToLetterDic()
        {
            MakeTableOffLetterOfTextFrequency();
            LoadTableFromFileToTemplateFrequency();

            letterToLetter = new Dictionary<char, char>();
            frequencyTable = frequencyTable.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            templateTable = templateTable.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            List<char> lettersFromFrequency = new List<char>();
            foreach (char letter in frequencyTable.Keys)
            {
                lettersFromFrequency.Add(letter);
            }
            int i = 0;
            foreach (char letter in templateTable.Keys)
            {
                letterToLetter.Add(letter, lettersFromFrequency[i]);
                i++;
            }
        }

        private void makeTableTemplateToFrequencyInText_Click(object sender, EventArgs e)
        {
            if (letterToLetter.Count == 0)
                makeLetterToLetterDic();

            // Clear existing items in the list view
            listView1.Items.Clear();

            // Loop through each dictionary entry and create a list view item with the character and its frequency
            foreach (var dictionary in letterToLetter)
            {
                ListViewItem item = new ListViewItem(dictionary.Key.ToString());
                item.SubItems.Add(dictionary.Value.ToString());
                listView1.Items.Add(item);
            }
        }

        private void ButtonToDecipher_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
                makeTableTemplateToFrequencyInText_Click(sender, e);

            string textToRemake = textToDecipher;
            TextBoxWithData.Text = new string(textToRemake.Select(character => letterToLetter.ContainsValue(character) ? letterToLetter.FirstOrDefault(x => x.Value == character).Key : character).ToArray());
        }

        private void loadTextToFile_Click(object sender, EventArgs e)
        {
            string filePath = MainForm.openFileDialogToLoadFile();
            if (filePath == null)
                return;

            // Create a StreamWriter instance to write the table to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(TextBoxWithData.Text);
            }
        }

        private void LoadTableToFile_Click(object sender, EventArgs e)
        {
            if (letterToLetter.Count == 0)
            {
                MessageBox.Show("You have no table to load it to file. Please first make table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fileName = MainForm.openFileDialogToLoadFile();
            if (fileName == null)
            {
                MessageBox.Show("You haven`t choose file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create a StreamWriter instance to write the table to the file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var dictionary in letterToLetter)
                {
                    writer.Write(dictionary.Key.ToString());
                    writer.Write(",");
                    writer.Write(dictionary.Value.ToString());
                    writer.WriteLine();
                }
            }
        }

        private void LoadTableFromFile_Click(object sender, EventArgs e)
        {
            string fileName = MainForm.openFileDialogToLoadFile();
            if (fileName == null)
            {
                MessageBox.Show("You haven`t choose file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            letterToLetter = new Dictionary<char, char>();
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

                    try { letterToLetter.Add(charsOne[0], charsTwo[0]); }
                    catch
                    {
                        MessageBox.Show("You have chose file with not valiable data, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            makeTableTemplateToFrequencyInText_Click(sender, e);
        }

        private void changeLetters_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("You haven`t got any date in list view. Please first add some date to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            letterToLetter = new Dictionary<char, char>();
            foreach (ListViewItem item in listView1.Items)
            {
                // Get the key and value characters from the item
                char key = item.SubItems[0].Text[0];
                char value = item.SubItems[1].Text[0];

                // Add the key-value pair to the dictionary
                letterToLetter.Add(key, value);
            }
            ButtonToDecipher_Click(sender, e);
        }
    }
}
