namespace Cryptology
{
    partial class WigenerCipherForm
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
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.Cipher = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.LoadTextFromFile = new System.Windows.Forms.Button();
            this.LoadTextToFile = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Decipher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonToOpenMainForm
            // 
            this.ButtonToOpenMainForm.Location = new System.Drawing.Point(12, 399);
            this.ButtonToOpenMainForm.Name = "ButtonToOpenMainForm";
            this.ButtonToOpenMainForm.Size = new System.Drawing.Size(372, 39);
            this.ButtonToOpenMainForm.TabIndex = 0;
            this.ButtonToOpenMainForm.Text = "Main Form";
            this.ButtonToOpenMainForm.UseVisualStyleBackColor = true;
            this.ButtonToOpenMainForm.Click += new System.EventHandler(this.ButtonToOpenMainForm_Click);
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(12, 12);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(587, 381);
            this.textTextBox.TabIndex = 1;
            this.textTextBox.Text = "You have add no text. To add text press \"Chose file, to read the data.\" button.";
            // 
            // Cipher
            // 
            this.Cipher.Location = new System.Drawing.Point(604, 12);
            this.Cipher.Name = "Cipher";
            this.Cipher.Size = new System.Drawing.Size(184, 80);
            this.Cipher.TabIndex = 2;
            this.Cipher.Text = "Cipher";
            this.Cipher.UseVisualStyleBackColor = true;
            this.Cipher.Click += new System.EventHandler(this.Cipher_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(390, 399);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(209, 39);
            this.keyTextBox.TabIndex = 3;
            this.keyTextBox.Text = "Enter key: ";
            // 
            // LoadTextFromFile
            // 
            this.LoadTextFromFile.Location = new System.Drawing.Point(604, 184);
            this.LoadTextFromFile.Name = "LoadTextFromFile";
            this.LoadTextFromFile.Size = new System.Drawing.Size(184, 80);
            this.LoadTextFromFile.TabIndex = 4;
            this.LoadTextFromFile.Text = "Load text from file.";
            this.LoadTextFromFile.UseVisualStyleBackColor = true;
            this.LoadTextFromFile.Click += new System.EventHandler(this.LoadTextFromFile_Click);
            // 
            // LoadTextToFile
            // 
            this.LoadTextToFile.Location = new System.Drawing.Point(605, 270);
            this.LoadTextToFile.Name = "LoadTextToFile";
            this.LoadTextToFile.Size = new System.Drawing.Size(184, 80);
            this.LoadTextToFile.TabIndex = 5;
            this.LoadTextToFile.Text = "Load text to file.";
            this.LoadTextToFile.UseVisualStyleBackColor = true;
            this.LoadTextToFile.Click += new System.EventHandler(this.LoadTextToFile_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(605, 358);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(184, 80);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Decipher
            // 
            this.Decipher.Location = new System.Drawing.Point(605, 98);
            this.Decipher.Name = "Decipher";
            this.Decipher.Size = new System.Drawing.Size(184, 80);
            this.Decipher.TabIndex = 7;
            this.Decipher.Text = "Decipher";
            this.Decipher.UseVisualStyleBackColor = true;
            this.Decipher.Click += new System.EventHandler(this.Decipher_Click);
            // 
            // WigenerCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Decipher);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.LoadTextToFile);
            this.Controls.Add(this.LoadTextFromFile);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.Cipher);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.ButtonToOpenMainForm);
            this.Name = "WigenerCipherForm";
            this.Text = "WigenerCipher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeThisForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonToOpenMainForm;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Button Cipher;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button LoadTextFromFile;
        private System.Windows.Forms.Button LoadTextToFile;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Decipher;
    }
}