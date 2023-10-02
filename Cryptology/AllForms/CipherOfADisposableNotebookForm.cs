using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptology
{
    public partial class CipherOfADisposableNotebookForm : Form
    {
        MainForm mainForm;
        private string text;
        private string key;

        #region Variables for resize and resize realization
        private Size formOriginalSize;
        private Rectangle rectextTextBox;
        private Rectangle recMainForm;
        private Rectangle recCipher;
        private Rectangle recDecipher;
        private Rectangle recLoadTextFromFile;
        private Rectangle recLoadTextToFile;
        private Rectangle recEnterKey;
        private Rectangle recReset;

        private void ConstructioOfFrequencyTablesForm_Resiz(object sender, EventArgs e)
        {
            MainForm.resize_Control(this, formOriginalSize, textTextBox, rectextTextBox);
            MainForm.resize_Control(this, formOriginalSize, ButtonToOpenMainForm, recMainForm);
            MainForm.resize_Control(this, formOriginalSize, Cipher, recCipher);
            MainForm.resize_Control(this, formOriginalSize, Decipher, recDecipher);
            MainForm.resize_Control(this, formOriginalSize, LoadTextFromFile, recLoadTextFromFile);
            MainForm.resize_Control(this, formOriginalSize, LoadTextToFile, recLoadTextToFile);
            MainForm.resize_Control(this, formOriginalSize, keyTextBox, recEnterKey);
            MainForm.resize_Control(this, formOriginalSize, Reset, recReset);
        }
        #endregion
        public CipherOfADisposableNotebookForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            text = key = "";

            #region Initializate variables for resize
            this.Resize += ConstructioOfFrequencyTablesForm_Resiz;
            formOriginalSize = this.Size;
            rectextTextBox = new Rectangle(textTextBox.Location, textTextBox.Size);
            recMainForm = new Rectangle(ButtonToOpenMainForm.Location, ButtonToOpenMainForm.Size);
            recCipher = new Rectangle(Cipher.Location, Cipher.Size);
            recDecipher = new Rectangle(Decipher.Location, Decipher.Size);
            recLoadTextFromFile = new Rectangle(LoadTextFromFile.Location, LoadTextFromFile.Size);
            recLoadTextToFile = new Rectangle(LoadTextToFile.Location, LoadTextToFile.Size);
            recEnterKey = new Rectangle(keyTextBox.Location, keyTextBox.Size);
            recReset = new Rectangle(Reset.Location, Reset.Size);
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

        private void MakeSecondStringSameSize()
        {
            if (key == "" || text == "")
            {
                MessageBox.Show("No date to change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate the number of times to duplicate the key string
            int numDuplicates = (int)Math.Ceiling((double)text.Length / key.Length);

            // Duplicate the key string the appropriate number of times
            key = string.Concat(Enumerable.Repeat(key, numDuplicates));

            // Trim the duplicated string to the correct length
            key = key.Substring(0, text.Length);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            keyTextBox.Text = "Enter key: ";
            textTextBox.Text = "You have add no text. To add text press \"Chose file, to read the data.\" button.";
        }

        private void LoadTextToFile_Click(object sender, EventArgs e)
        {
            string filePath = MainForm.openFileDialogToLoadFile();
            if (filePath == null)
                return;

            // Create a StreamWriter instance to write the table to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(textTextBox.Text);
            }
        }

        private void LoadTextFromFile_Click(object sender, EventArgs e)
        {
            string fileName = MainForm.openFileDialogToLoadFile();
            if (fileName == null)
                return;

            string readedText = File.ReadAllText(fileName);

            text = readedText;
            textTextBox.Text = text;
            textTextBox.ScrollBars = ScrollBars.Both;
        }

        private void Cipher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textTextBox.Text)
                || textTextBox.Text == "You have add no text. To add text press \"Chose file, to read the data.\" button."
                || textTextBox.Text == "Plese, before making any operations load text. You have add no text. To add text press \"Chose file, to read the data.\" button."
                || keyTextBox.Text == "Enter key: ")
            {
                MessageBox.Show("Plese add some text, before any actions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textTextBox.Text = "Plese, before making any operations load text. You have add no text. To add text press \"Chose file, to read the data.\" button.";
                return;
            }
            this.text = textTextBox.Text;
            this.key = keyTextBox.Text;

            string ciphertext = "";
            int keyIndex = 0;

            foreach (char c in text)
            {
                int plainChar = (int)c;
                int keyChar = (int)key[keyIndex];

                int cipherChar = (plainChar ^ keyChar) % 256;
                ciphertext += (char)cipherChar;

                keyIndex++;
                if (keyIndex >= key.Length)
                    keyIndex = 0;
            }
            textTextBox.Text = ciphertext;
        }

        private void Decipher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textTextBox.Text)
            || textTextBox.Text == "You have add no text. To add text press \"Chose file, to read the data.\" button."
            || textTextBox.Text == "Plese, before making any operations load text. You have add no text. To add text press \"Chose file, to read the data.\" button."
            || keyTextBox.Text == "Enter key: ")
            {
                MessageBox.Show("Plese add some text, before any actions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textTextBox.Text = "Plese, before making any operations load text. You have add no text. To add text press \"Chose file, to read the data.\" button.";
                return;
            }
            this.text = textTextBox.Text;
            this.key = keyTextBox.Text;
            MakeSecondStringSameSize();


            string plaintext = "";
            int keyIndex = 0;

            foreach (char c in text)
            {
                int plainChar = (int)c;
                int keyChar = (int)key[keyIndex];

                int cipherChar = (plainChar ^ keyChar) % 256;
                plaintext += (char)cipherChar;

                keyIndex++;
                if (keyIndex >= key.Length)
                    keyIndex = 0;
            }

            textTextBox.Text = plaintext;
        }
    }
}
