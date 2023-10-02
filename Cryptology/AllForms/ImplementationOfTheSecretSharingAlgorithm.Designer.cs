namespace Cryptology.AllForms
{
    partial class ImplementationOfTheSecretSharingAlgorithm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMainForm
            // 
            this.buttonMainForm.Location = new System.Drawing.Point(12, 360);
            this.buttonMainForm.Name = "buttonMainForm";
            this.buttonMainForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMainForm.Size = new System.Drawing.Size(427, 78);
            this.buttonMainForm.TabIndex = 4;
            this.buttonMainForm.Text = "Main form";
            this.buttonMainForm.UseVisualStyleBackColor = true;
            this.buttonMainForm.Click += new System.EventHandler(this.buttonMainForm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(776, 338);
            this.textBox1.TabIndex = 5;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(445, 360);
            this.check.Name = "check";
            this.check.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.check.Size = new System.Drawing.Size(343, 78);
            this.check.TabIndex = 6;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // ImplementationOfTheSecretSharingAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonMainForm);
            this.Name = "ImplementationOfTheSecretSharingAlgorithm";
            this.Text = "ImplementationOfTheSecretSharingAlgorithm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeThisForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainForm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button check;
    }
}