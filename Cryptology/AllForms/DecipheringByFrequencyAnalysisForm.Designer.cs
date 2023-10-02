using System.Windows.Forms;

namespace Cryptology
{
    partial class DecipheringByFrequencyAnalysisForm
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
            this.TextBoxWithData = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Char = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TemplateChar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadTextForDecipher = new System.Windows.Forms.Button();
            this.ButtonToDecipher = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.loadTextToFile = new System.Windows.Forms.Button();
            this.changeLetters = new System.Windows.Forms.Button();
            this.LoadTableFromFile = new System.Windows.Forms.Button();
            this.LoadTableToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonToOpenMainForm
            // 
            this.ButtonToOpenMainForm.Location = new System.Drawing.Point(12, 401);
            this.ButtonToOpenMainForm.Name = "ButtonToOpenMainForm";
            this.ButtonToOpenMainForm.Size = new System.Drawing.Size(347, 34);
            this.ButtonToOpenMainForm.TabIndex = 0;
            this.ButtonToOpenMainForm.Text = "Main Form";
            this.ButtonToOpenMainForm.UseVisualStyleBackColor = true;
            this.ButtonToOpenMainForm.Click += new System.EventHandler(this.ButtonToOpenMainForm_Click);
            // 
            // TextBoxWithData
            // 
            this.TextBoxWithData.Location = new System.Drawing.Point(12, 9);
            this.TextBoxWithData.Multiline = true;
            this.TextBoxWithData.Name = "TextBoxWithData";
            this.TextBoxWithData.Size = new System.Drawing.Size(347, 386);
            this.TextBoxWithData.TabIndex = 1;
            this.TextBoxWithData.Text = "You have add no text. To add text press \"Chose file, to read the data.\" button.";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Char,
            this.TemplateChar});
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(572, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(216, 386);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // Enable label editing for the ListView
            listView1.LabelEdit = true;
            // 
            // Char
            // 
            this.Char.Text = "Char";
            this.Char.Width = 62;
            // 
            // TemplateChar
            // 
            this.TemplateChar.Text = "Template char";
            this.TemplateChar.Width = 100;
            // 
            // loadTextForDecipher
            // 
            this.loadTextForDecipher.Location = new System.Drawing.Point(365, 9);
            this.loadTextForDecipher.Name = "loadTextForDecipher";
            this.loadTextForDecipher.Size = new System.Drawing.Size(201, 66);
            this.loadTextForDecipher.TabIndex = 3;
            this.loadTextForDecipher.Text = "Load text to decipher.";
            this.loadTextForDecipher.UseVisualStyleBackColor = true;
            this.loadTextForDecipher.Click += new System.EventHandler(this.loadTextForDecipher_Click);
            // 
            // ButtonToDecipher
            // 
            this.ButtonToDecipher.Location = new System.Drawing.Point(365, 81);
            this.ButtonToDecipher.Name = "ButtonToDecipher";
            this.ButtonToDecipher.Size = new System.Drawing.Size(201, 66);
            this.ButtonToDecipher.TabIndex = 5;
            this.ButtonToDecipher.Text = "Decipher.";
            this.ButtonToDecipher.UseVisualStyleBackColor = true;
            this.ButtonToDecipher.Click += new System.EventHandler(this.ButtonToDecipher_Click);
            // 
            // Reset
            // 
            this.Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reset.Location = new System.Drawing.Point(365, 369);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(201, 66);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset.";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // loadTextToFile
            // 
            this.loadTextToFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadTextToFile.Location = new System.Drawing.Point(365, 153);
            this.loadTextToFile.Name = "loadTextToFile";
            this.loadTextToFile.Size = new System.Drawing.Size(201, 66);
            this.loadTextToFile.TabIndex = 8;
            this.loadTextToFile.Text = "Load text to file.";
            this.loadTextToFile.UseVisualStyleBackColor = true;
            this.loadTextToFile.Click += new System.EventHandler(this.loadTextToFile_Click);
            // 
            // changeLetters
            // 
            this.changeLetters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeLetters.Location = new System.Drawing.Point(572, 401);
            this.changeLetters.Name = "changeLetters";
            this.changeLetters.Size = new System.Drawing.Size(216, 37);
            this.changeLetters.TabIndex = 11;
            this.changeLetters.Text = "Change Letters.";
            this.changeLetters.UseVisualStyleBackColor = true;
            this.changeLetters.Click += new System.EventHandler(this.changeLetters_Click);
            // 
            // LoadTableFromFile
            // 
            this.LoadTableFromFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadTableFromFile.Location = new System.Drawing.Point(365, 297);
            this.LoadTableFromFile.Name = "LoadTableFromFile";
            this.LoadTableFromFile.Size = new System.Drawing.Size(201, 66);
            this.LoadTableFromFile.TabIndex = 12;
            this.LoadTableFromFile.Text = "Load table from file.";
            this.LoadTableFromFile.UseVisualStyleBackColor = true;
            this.LoadTableFromFile.Click += new System.EventHandler(this.LoadTableFromFile_Click);
            // 
            // LoadTableToFile
            // 
            this.LoadTableToFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadTableToFile.Location = new System.Drawing.Point(365, 225);
            this.LoadTableToFile.Name = "LoadTableToFile";
            this.LoadTableToFile.Size = new System.Drawing.Size(201, 66);
            this.LoadTableToFile.TabIndex = 13;
            this.LoadTableToFile.Text = "Load table to file.";
            this.LoadTableToFile.UseVisualStyleBackColor = true;
            this.LoadTableToFile.Click += new System.EventHandler(this.LoadTableToFile_Click);
            // 
            // DecipheringByFrequencyAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadTableToFile);
            this.Controls.Add(this.LoadTableFromFile);
            this.Controls.Add(this.changeLetters);
            this.Controls.Add(this.loadTextToFile);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ButtonToDecipher);
            this.Controls.Add(this.loadTextForDecipher);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TextBoxWithData);
            this.Controls.Add(this.ButtonToOpenMainForm);
            this.Name = "DecipheringByFrequencyAnalysisForm";
            this.Text = "DecipheringByFrequencyAnalysisForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeThisForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonToOpenMainForm;
        private System.Windows.Forms.TextBox TextBoxWithData;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Char;
        private System.Windows.Forms.ColumnHeader TemplateChar;
        private System.Windows.Forms.Button loadTextForDecipher;
        private System.Windows.Forms.Button ButtonToDecipher;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button loadTextToFile;
        private System.Windows.Forms.Button changeLetters;
        private System.Windows.Forms.Button LoadTableFromFile;
        private System.Windows.Forms.Button LoadTableToFile;
    }
}