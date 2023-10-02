namespace Cryptology
{
    partial class SimpleSubstitutionCipherForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.usualChar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randomChar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.makeRandomTable = new System.Windows.Forms.Button();
            this.loadTableFromFile = new System.Windows.Forms.Button();
            this.loadTableToFile = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.textBoxShowText = new System.Windows.Forms.TextBox();
            this.buttonToLoadText = new System.Windows.Forms.Button();
            this.cipherText = new System.Windows.Forms.Button();
            this.decipherText = new System.Windows.Forms.Button();
            this.loadTextToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonToOpenMainForm
            // 
            this.ButtonToOpenMainForm.AutoSize = true;
            this.ButtonToOpenMainForm.Location = new System.Drawing.Point(12, 359);
            this.ButtonToOpenMainForm.Name = "ButtonToOpenMainForm";
            this.ButtonToOpenMainForm.Size = new System.Drawing.Size(316, 82);
            this.ButtonToOpenMainForm.TabIndex = 0;
            this.ButtonToOpenMainForm.Text = "Main form";
            this.ButtonToOpenMainForm.UseVisualStyleBackColor = true;
            this.ButtonToOpenMainForm.Click += new System.EventHandler(this.ButtonToOpenMainForm_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usualChar,
            this.randomChar});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(604, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(184, 444);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // usualChar
            // 
            this.usualChar.Text = "Char";
            // 
            // randomChar
            // 
            this.randomChar.Text = "Random char";
            // 
            // makeRandomTable
            // 
            this.makeRandomTable.AutoSize = true;
            this.makeRandomTable.Location = new System.Drawing.Point(12, 7);
            this.makeRandomTable.Name = "makeRandomTable";
            this.makeRandomTable.Size = new System.Drawing.Size(155, 82);
            this.makeRandomTable.TabIndex = 4;
            this.makeRandomTable.Text = "Make random table.";
            this.makeRandomTable.UseVisualStyleBackColor = true;
            this.makeRandomTable.Click += new System.EventHandler(this.makeRandomTable_Click);
            // 
            // loadTableFromFile
            // 
            this.loadTableFromFile.AutoSize = true;
            this.loadTableFromFile.Location = new System.Drawing.Point(174, 7);
            this.loadTableFromFile.Name = "loadTableFromFile";
            this.loadTableFromFile.Size = new System.Drawing.Size(155, 82);
            this.loadTableFromFile.TabIndex = 5;
            this.loadTableFromFile.Text = "Load table from file.";
            this.loadTableFromFile.UseVisualStyleBackColor = true;
            this.loadTableFromFile.Click += new System.EventHandler(this.loadTableFromFile_Click);
            // 
            // loadTableToFile
            // 
            this.loadTableToFile.AutoSize = true;
            this.loadTableToFile.Location = new System.Drawing.Point(12, 95);
            this.loadTableToFile.Name = "loadTableToFile";
            this.loadTableToFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loadTableToFile.Size = new System.Drawing.Size(155, 82);
            this.loadTableToFile.TabIndex = 6;
            this.loadTableToFile.Text = "Load table to file.";
            this.loadTableToFile.UseVisualStyleBackColor = true;
            this.loadTableToFile.Click += new System.EventHandler(this.loadTableToFile_Click);
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Location = new System.Drawing.Point(174, 271);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(155, 82);
            this.reset.TabIndex = 7;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // textBoxShowText
            // 
            this.textBoxShowText.Location = new System.Drawing.Point(335, 7);
            this.textBoxShowText.Multiline = true;
            this.textBoxShowText.Name = "textBoxShowText";
            this.textBoxShowText.Size = new System.Drawing.Size(263, 444);
            this.textBoxShowText.TabIndex = 8;
            this.textBoxShowText.Text = "You have add no text. To add text press \"Chose file, to read the data.\" button.";
            // 
            // buttonToLoadText
            // 
            this.buttonToLoadText.AutoSize = true;
            this.buttonToLoadText.Location = new System.Drawing.Point(173, 95);
            this.buttonToLoadText.Name = "buttonToLoadText";
            this.buttonToLoadText.Size = new System.Drawing.Size(155, 82);
            this.buttonToLoadText.TabIndex = 9;
            this.buttonToLoadText.Text = "Load text from file.";
            this.buttonToLoadText.UseVisualStyleBackColor = true;
            this.buttonToLoadText.Click += new System.EventHandler(this.buttonToLoadText_Click);
            // 
            // cipherText
            // 
            this.cipherText.AutoSize = true;
            this.cipherText.Location = new System.Drawing.Point(173, 183);
            this.cipherText.Name = "cipherText";
            this.cipherText.Size = new System.Drawing.Size(155, 82);
            this.cipherText.TabIndex = 10;
            this.cipherText.Text = "Cipher text.";
            this.cipherText.UseVisualStyleBackColor = true;
            this.cipherText.Click += new System.EventHandler(this.cipherText_Click);
            // 
            // decipherText
            // 
            this.decipherText.AutoSize = true;
            this.decipherText.Location = new System.Drawing.Point(12, 271);
            this.decipherText.Name = "decipherText";
            this.decipherText.Size = new System.Drawing.Size(155, 82);
            this.decipherText.TabIndex = 11;
            this.decipherText.Text = "Decipher the text";
            this.decipherText.UseVisualStyleBackColor = true;
            this.decipherText.Click += new System.EventHandler(this.decipherText_Click);
            // 
            // loadTextToFile
            // 
            this.loadTextToFile.AutoSize = true;
            this.loadTextToFile.Location = new System.Drawing.Point(12, 183);
            this.loadTextToFile.Name = "loadTextToFile";
            this.loadTextToFile.Size = new System.Drawing.Size(155, 82);
            this.loadTextToFile.TabIndex = 12;
            this.loadTextToFile.Text = "Load text to file.";
            this.loadTextToFile.UseVisualStyleBackColor = true;
            this.loadTextToFile.Click += new System.EventHandler(this.loadTextToFile_Click);
            // 
            // SimpleSubstitutionCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.loadTextToFile);
            this.Controls.Add(this.decipherText);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.buttonToLoadText);
            this.Controls.Add(this.textBoxShowText);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.loadTableToFile);
            this.Controls.Add(this.loadTableFromFile);
            this.Controls.Add(this.makeRandomTable);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ButtonToOpenMainForm);
            this.Name = "SimpleSubstitutionCipherForm";
            this.Text = "SimpleSubstitutionCipherForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeThisForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonToOpenMainForm;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader usualChar;
        private System.Windows.Forms.ColumnHeader randomChar;
        private System.Windows.Forms.Button makeRandomTable;
        private System.Windows.Forms.Button loadTableFromFile;
        private System.Windows.Forms.Button loadTableToFile;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox textBoxShowText;
        private System.Windows.Forms.Button buttonToLoadText;
        private System.Windows.Forms.Button cipherText;
        private System.Windows.Forms.Button decipherText;
        private System.Windows.Forms.Button loadTextToFile;
    }
}