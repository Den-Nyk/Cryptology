namespace Cryptology.AllForms
{
    partial class ImplementationOfADigitalSignatureInTheRSASystem
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox3 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.checkMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMainForm
            // 
            this.buttonMainForm.Location = new System.Drawing.Point(12, 392);
            this.buttonMainForm.Name = "buttonMainForm";
            this.buttonMainForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMainForm.Size = new System.Drawing.Size(427, 46);
            this.buttonMainForm.TabIndex = 3;
            this.buttonMainForm.Text = "Main form";
            this.buttonMainForm.UseVisualStyleBackColor = true;
            this.buttonMainForm.Click += new System.EventHandler(this.buttonMainForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 340);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(214, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Choose text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(405, 155);
            this.richTextBox1.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(423, 12);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(365, 155);
            this.textBox4.TabIndex = 6;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(308, 340);
            this.calculate.Name = "calculate";
            this.calculate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculate.Size = new System.Drawing.Size(214, 46);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 212);
            this.richTextBox2.Multiline = true;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(290, 62);
            this.richTextBox2.TabIndex = 8;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(308, 212);
            this.richTextBox3.Multiline = true;
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(237, 62);
            this.richTextBox3.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(551, 212);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 62);
            this.textBox3.TabIndex = 10;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(574, 340);
            this.check.Name = "check";
            this.check.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.check.Size = new System.Drawing.Size(214, 46);
            this.check.TabIndex = 11;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // checkMod
            // 
            this.checkMod.Location = new System.Drawing.Point(574, 392);
            this.checkMod.Name = "checkMod";
            this.checkMod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkMod.Size = new System.Drawing.Size(214, 46);
            this.checkMod.TabIndex = 12;
            this.checkMod.Text = "Check modification";
            this.checkMod.UseVisualStyleBackColor = true;
            this.checkMod.Click += new System.EventHandler(this.checkMod_Click);
            // 
            // ImplementationOfADigitalSignatureInTheRSASystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkMod);
            this.Controls.Add(this.check);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMainForm);
            this.Name = "ImplementationOfADigitalSignatureInTheRSASystem";
            this.Text = "ImplementationOfADigitalSignatureInTheRSASystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeThisForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox richTextBox2;
        private System.Windows.Forms.TextBox richTextBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button checkMod;
    }
}