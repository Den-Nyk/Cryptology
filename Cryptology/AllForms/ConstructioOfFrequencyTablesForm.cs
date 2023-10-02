using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace Cryptology
{
    public partial class ConstructioOfFrequencyTablesForm : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        private MainForm mainForm;

        #region Variables for resize and resize realization
        private Size formOriginalSize;
        private Rectangle recTextBox;
        private Rectangle recMainFormButton;
        private Rectangle recChoseFileToReadTheDataButton;
        private Rectangle recLoadTableButton;
        private Rectangle recLoadFromTableButton;
        private Rectangle recListViev;
        private Rectangle recResetButton;
        
        private void ConstructioOfFrequencyTablesForm_Resiz(object sender, EventArgs e)
        {
            MainForm.resize_Control(this, formOriginalSize, TextBoxShowData, recTextBox);
            MainForm.resize_Control(this, formOriginalSize, ButtonToOpenMainForm, recMainFormButton);
            MainForm.resize_Control(this, formOriginalSize, ButtonToChoseFileToReadData, recChoseFileToReadTheDataButton);
            MainForm.resize_Control(this, formOriginalSize, ButtonToLoadTableToFile, recLoadTableButton);
            MainForm.resize_Control(this, formOriginalSize, ButtonToLoadTableFromFile, recLoadFromTableButton);
            MainForm.resize_Control(this, formOriginalSize, listView1, recListViev);
            MainForm.resize_Control(this, formOriginalSize, ButtonToResetAll, recResetButton);
        }
        #endregion

        public ConstructioOfFrequencyTablesForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;

            #region Inicialize components for resize
            this.formOriginalSize = this.Size;
            this.Resize += ConstructioOfFrequencyTablesForm_Resiz;
            this.recTextBox = new Rectangle(TextBoxShowData.Location, TextBoxShowData.Size);
            this.recMainFormButton = new Rectangle(ButtonToOpenMainForm.Location, ButtonToOpenMainForm.Size);
            this.recChoseFileToReadTheDataButton = new Rectangle(ButtonToChoseFileToReadData.Location, ButtonToChoseFileToReadData.Size);
            this.recLoadTableButton = new Rectangle(ButtonToLoadTableToFile.Location, ButtonToLoadTableToFile.Size);
            this.recLoadFromTableButton = new Rectangle(ButtonToLoadTableFromFile.Location, ButtonToLoadTableFromFile.Size);
            this.recListViev = new Rectangle(listView1.Location, listView1.Size);
            this.recResetButton = new Rectangle(ButtonToResetAll.Location, ButtonToResetAll.Size);
            #endregion
        }

        // Method to show the main form and close this form when it's closing
        private void closeThisForm(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        // Method to close this form and go back to the main form
        private void ButtonToOpenMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string changeText()
        {
            while (true)
            {
                // If the textbox is empty or has a default message, prompt the user to add text
                if (string.IsNullOrEmpty(TextBoxShowData.Text)
                    || TextBoxShowData.Text == "You have add no text. To add text press \"Chose file, to read the data.\" button."
                    || TextBoxShowData.Text == "Plese, before making any operations load text. You have add no text. To add text press \"Chose file, to read the data.\" button.")
                {
                    MessageBox.Show("Plese add some text, before any actions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxShowData.Text = "Plese, before making any operations load text. You have add no text. To add text press \"Chose file, to read the data.\" button.";
                    readDataAndFillItInMessageBox();
                }
                else
                {
                    // Replace all non-letter characters with an empty string and make the text lowercase
                    Regex regex = new Regex("[^a-z]");
                    TextBoxShowData.Text.ToLower(); 
                    string textToLover = TextBoxShowData.Text.ToLower();
                    return regex.Replace(textToLover, "");
                }
            }
        }

        private Dictionary<char, double> makeDictionaryOfCharAndFrequency()
        {
            // Get the text with only letters
            string standardizedText = changeText();

            // Count the number of letters in the text
            int length = standardizedText.Length;

            // Group the letters and count their frequency
            return standardizedText.GroupBy(letter => letter).ToDictionary(element => element.Key, element => element.Count() / Convert.ToDouble(length));
        }

        private void readDataAndFillItInMessageBox()
        {
            string fileName = MainForm.openFileDialogToLoadFile();
            if (fileName == null)
                return;

            string text = File.ReadAllText(fileName);

            TextBoxShowData.Text = text;
            TextBoxShowData.ScrollBars = ScrollBars.Both;
        }

        private void makeTable()
        {
            // Call method to create a dictionary of characters and their frequency
            var dictionaryOfLettersAndTheirFrequency = makeDictionaryOfCharAndFrequency();

            // Clear existing items in the list view
            listView1.Items.Clear();

            // Loop through each dictionary entry and create a list view item with the character and its frequency
            foreach (var dictionary in dictionaryOfLettersAndTheirFrequency)
            {
                ListViewItem item = new ListViewItem(dictionary.Key.ToString());
                item.SubItems.Add(dictionary.Value.ToString());
                listView1.Items.Add(item);
            }
        }

        private void ButtonToChoseFileToReadData_Click(object sender, EventArgs e)
        {
            // Call method to read data from file and display it in a message box
            readDataAndFillItInMessageBox();

            // Call method to create a table displaying the frequency of each character in the loaded text
            makeTable();
        }

        private void ButtonToLoadTableToFile_Click(object sender, EventArgs e)
        {
            string filePath = MainForm.openFileDialogToLoadFile();
            if (filePath == null)
                return;

            // Create a StreamWriter instance to write the table to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        writer.Write(item.SubItems[i].Text);

                        // Add a period separator between sub items, except for the last one
                        if (i < item.SubItems.Count - 1)
                        {
                            writer.Write(".");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }

        private void ButtonToLoadTableFromFile_Click(object sender, EventArgs e)
        {
            string fileName = MainForm.openFileDialogToLoadFile();

            // Open a StreamReader to read the file line by line.
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Continue reading the file until the end of the stream is reached.
                while (!reader.EndOfStream)
                {
                    // Read a line from the file and split it into separate values based on the '.' delimiter.
                    string line = reader.ReadLine();
                    string[] values = line.Split('.');

                    // Create a new ListViewItem with the first value as the text and the second value as a subitem.
                    ListViewItem item = new ListViewItem(values[0]);
                    double value = 0;

                    // Try to parse the second value as a double and add it as a subitem if successful.
                    if (double.TryParse(values[1], out value))
                    {
                        item.SubItems.Add((value/100).ToString());
                    }

                    // Add the ListViewItem to the ListView control.
                    listView1.Items.Add(item);
                }
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listView1.Sort();
        }

        private void ButtonToResetAll_Click(object sender, EventArgs e)
        {
            TextBoxShowData.Text = "You have add no text. To add text press \"Chose file, to read the data.\" button";
            listView1.Items.Clear();
        }
    }
}
