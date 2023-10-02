using System.Windows.Forms;

namespace Cryptology
{
    partial class ConstructioOfFrequencyTablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonToOpenMainForm = new System.Windows.Forms.Button();
            this.ButtonToChoseFileToReadData = new System.Windows.Forms.Button();
            this.TextBoxShowData = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Char = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonToLoadTableToFile = new System.Windows.Forms.Button();
            this.ButtonToLoadTableFromFile = new System.Windows.Forms.Button();
            this.ButtonToResetAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonToOpenMainForm
            // 
            this.ButtonToOpenMainForm.AutoSize = true;
            this.ButtonToOpenMainForm.Location = new System.Drawing.Point(12, 406);
            this.ButtonToOpenMainForm.Name = "ButtonToOpenMainForm";
            this.ButtonToOpenMainForm.Size = new System.Drawing.Size(402, 32);
            this.ButtonToOpenMainForm.TabIndex = 0;
            this.ButtonToOpenMainForm.Text = "Main Form";
            this.ButtonToOpenMainForm.UseVisualStyleBackColor = true;
            this.ButtonToOpenMainForm.Click += new System.EventHandler(this.ButtonToOpenMainForm_Click);
            // 
            // ButtonToChoseFileToReadData
            // 
            this.ButtonToChoseFileToReadData.AutoSize = true;
            this.ButtonToChoseFileToReadData.Location = new System.Drawing.Point(420, 12);
            this.ButtonToChoseFileToReadData.Name = "ButtonToChoseFileToReadData";
            this.ButtonToChoseFileToReadData.Size = new System.Drawing.Size(150, 100);
            this.ButtonToChoseFileToReadData.TabIndex = 1;
            this.ButtonToChoseFileToReadData.Text = "Load text form file";
            this.ButtonToChoseFileToReadData.UseVisualStyleBackColor = true;
            this.ButtonToChoseFileToReadData.Click += new System.EventHandler(this.ButtonToChoseFileToReadData_Click);
            // 
            // TextBoxShowData
            // 
            this.TextBoxShowData.Location = new System.Drawing.Point(12, 12);
            this.TextBoxShowData.Multiline = true;
            this.TextBoxShowData.Name = "TextBoxShowData";
            this.TextBoxShowData.Size = new System.Drawing.Size(402, 388);
            this.TextBoxShowData.TabIndex = 2;
            this.TextBoxShowData.Text = "You have add no text. To add text press \"Chose file, to read the data.\" button.";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Char,
            this.Frequency});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(576, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(212, 426);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // Char
            // 
            this.Char.Text = "Char";
            // 
            // Frequency
            // 
            this.Frequency.Text = "Frequency";
            this.Frequency.Width = 75;
            // 
            // ButtonToLoadTableToFile
            // 
            this.ButtonToLoadTableToFile.AutoSize = true;
            this.ButtonToLoadTableToFile.Location = new System.Drawing.Point(420, 118);
            this.ButtonToLoadTableToFile.Name = "ButtonToLoadTableToFile";
            this.ButtonToLoadTableToFile.Size = new System.Drawing.Size(150, 100);
            this.ButtonToLoadTableToFile.TabIndex = 4;
            this.ButtonToLoadTableToFile.Text = "Load this table to file.";
            this.ButtonToLoadTableToFile.UseVisualStyleBackColor = true;
            this.ButtonToLoadTableToFile.Click += new System.EventHandler(this.ButtonToLoadTableToFile_Click);
            // 
            // ButtonToLoadTableFromFile
            // 
            this.ButtonToLoadTableFromFile.AutoSize = true;
            this.ButtonToLoadTableFromFile.Location = new System.Drawing.Point(420, 224);
            this.ButtonToLoadTableFromFile.Name = "ButtonToLoadTableFromFile";
            this.ButtonToLoadTableFromFile.Size = new System.Drawing.Size(150, 100);
            this.ButtonToLoadTableFromFile.TabIndex = 5;
            this.ButtonToLoadTableFromFile.Text = "Load table from file.";
            this.ButtonToLoadTableFromFile.UseVisualStyleBackColor = true;
            this.ButtonToLoadTableFromFile.Click += new System.EventHandler(this.ButtonToLoadTableFromFile_Click);
            // 
            // ButtonToResetAll
            // 
            this.ButtonToResetAll.AutoSize = true;
            this.ButtonToResetAll.Location = new System.Drawing.Point(420, 330);
            this.ButtonToResetAll.Name = "ButtonToResetAll";
            this.ButtonToResetAll.Size = new System.Drawing.Size(150, 100);
            this.ButtonToResetAll.TabIndex = 6;
            this.ButtonToResetAll.Text = "Reset";
            this.ButtonToResetAll.UseVisualStyleBackColor = true;
            this.ButtonToResetAll.Click += new System.EventHandler(this.ButtonToResetAll_Click);
            // 
            // ConstructioOfFrequencyTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonToResetAll);
            this.Controls.Add(this.ButtonToLoadTableFromFile);
            this.Controls.Add(this.ButtonToLoadTableToFile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TextBoxShowData);
            this.Controls.Add(this.ButtonToChoseFileToReadData);
            this.Controls.Add(this.ButtonToOpenMainForm);
            this.Name = "ConstructioOfFrequencyTablesForm";
            this.Text = "ConstructioOfFrequencyTablesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeThisForm);
            this.ResumeLayout(false);
        }
        #endregion

        private Button ButtonToOpenMainForm;
        private Button ButtonToChoseFileToReadData;
        private TextBox TextBoxShowData;
        private ListView listView1;
        private ColumnHeader Char;
        private ColumnHeader Frequency;
        private Button ButtonToLoadTableToFile;
        private Button ButtonToLoadTableFromFile;
        private Button ButtonToResetAll;
    }
}