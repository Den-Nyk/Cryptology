namespace Cryptology.AllForms
{
    partial class RSACryptosystemForm
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
            this.buttonMainForm = new System.Windows.Forms.Button();
            this.allDateBox = new System.Windows.Forms.TextBox();
            this.Crypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.Label();
            this.QTextBox = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Label();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonMainForm
            // 
            this.buttonMainForm.Location = new System.Drawing.Point(12, 392);
            this.buttonMainForm.Name = "buttonMainForm";
            this.buttonMainForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMainForm.Size = new System.Drawing.Size(427, 46);
            this.buttonMainForm.TabIndex = 2;
            this.buttonMainForm.Text = "Main form";
            this.buttonMainForm.UseVisualStyleBackColor = true;
            this.buttonMainForm.Click += new System.EventHandler(this.buttonMainForm_Click);
            // 
            // allDateBox
            // 
            this.allDateBox.Location = new System.Drawing.Point(12, 12);
            this.allDateBox.Multiline = true;
            this.allDateBox.Name = "allDateBox";
            this.allDateBox.Size = new System.Drawing.Size(427, 374);
            this.allDateBox.TabIndex = 3;
            this.allDateBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            // 
            // Crypt
            // 
            this.Crypt.Location = new System.Drawing.Point(445, 12);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(343, 56);
            this.Crypt.TabIndex = 4;
            this.Crypt.Text = "Crypt";
            this.Crypt.UseVisualStyleBackColor = true;
            this.Crypt.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(445, 74);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(343, 56);
            this.decrypt.TabIndex = 5;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(445, 358);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(343, 80);
            this.reset.TabIndex = 6;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(445, 136);
            this.pTextBox.Multiline = true;
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(71, 61);
            this.pTextBox.TabIndex = 7;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(522, 160);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(19, 20);
            this.p.TabIndex = 8;
            this.p.Text = "p";
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Location = new System.Drawing.Point(706, 160);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(19, 20);
            this.q.TabIndex = 10;
            this.q.Text = "q";
            // 
            // QTextBox
            // 
            this.QTextBox.Location = new System.Drawing.Point(629, 136);
            this.QTextBox.Multiline = true;
            this.QTextBox.Name = "QTextBox";
            this.QTextBox.Size = new System.Drawing.Size(71, 61);
            this.QTextBox.TabIndex = 9;
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.n.Location = new System.Drawing.Point(706, 263);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(18, 20);
            this.n.TabIndex = 14;
            this.n.Text = "n";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(629, 239);
            this.nTextBox.Multiline = true;
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(71, 61);
            this.nTextBox.TabIndex = 13;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(522, 263);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(19, 20);
            this.d.TabIndex = 12;
            this.d.Text = "d";
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(445, 239);
            this.dTextBox.Multiline = true;
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(71, 61);
            this.dTextBox.TabIndex = 11;
            // 
            // RSACryptosystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.n);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.d);
            this.Controls.Add(this.dTextBox);
            this.Controls.Add(this.q);
            this.Controls.Add(this.QTextBox);
            this.Controls.Add(this.p);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.Crypt);
            this.Controls.Add(this.allDateBox);
            this.Controls.Add(this.buttonMainForm);
            this.Name = "RSACryptosystemForm";
            this.Text = "RSACryptosystemForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeThisForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainForm;
        private System.Windows.Forms.TextBox allDateBox;
        private System.Windows.Forms.Button Crypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label q;
        private System.Windows.Forms.TextBox QTextBox;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.TextBox dTextBox;
    }
}