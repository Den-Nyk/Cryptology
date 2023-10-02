namespace Cryptology.AllForms
{
    partial class ExtendedEuclidForm
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
            this.startEuclid = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.binaryButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zButton = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMainForm
            // 
            this.buttonMainForm.Location = new System.Drawing.Point(12, 395);
            this.buttonMainForm.Name = "buttonMainForm";
            this.buttonMainForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMainForm.Size = new System.Drawing.Size(427, 43);
            this.buttonMainForm.TabIndex = 0;
            this.buttonMainForm.Text = "Main form";
            this.buttonMainForm.UseVisualStyleBackColor = true;
            this.buttonMainForm.Click += new System.EventHandler(this.buttonMainForm_Click);
            // 
            // startEuclid
            // 
            this.startEuclid.Location = new System.Drawing.Point(455, 12);
            this.startEuclid.Name = "startEuclid";
            this.startEuclid.Size = new System.Drawing.Size(333, 56);
            this.startEuclid.TabIndex = 1;
            this.startEuclid.Text = "Euclid";
            this.startEuclid.UseVisualStyleBackColor = true;
            this.startEuclid.Click += new System.EventHandler(this.startEuclid_Click);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(12, 12);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(427, 377);
            this.answer.TabIndex = 2;
            // 
            // binaryButton
            // 
            this.binaryButton.Location = new System.Drawing.Point(455, 74);
            this.binaryButton.Name = "binaryButton";
            this.binaryButton.Size = new System.Drawing.Size(333, 44);
            this.binaryButton.TabIndex = 3;
            this.binaryButton.Text = "Binary";
            this.binaryButton.UseVisualStyleBackColor = true;
            this.binaryButton.Click += new System.EventHandler(this.binaryButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(455, 395);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(333, 43);
            this.randomButton.TabIndex = 4;
            this.randomButton.Text = "randon";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 224);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 165);
            this.textBox1.TabIndex = 5;
            // 
            // zButton
            // 
            this.zButton.Location = new System.Drawing.Point(455, 175);
            this.zButton.Name = "zButton";
            this.zButton.Size = new System.Drawing.Size(333, 43);
            this.zButton.TabIndex = 6;
            this.zButton.Text = "z*";
            this.zButton.UseVisualStyleBackColor = true;
            this.zButton.Click += new System.EventHandler(this.zButton_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(455, 126);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(333, 43);
            this.reset.TabIndex = 7;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // ExtendedEuclidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.zButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.binaryButton);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.startEuclid);
            this.Controls.Add(this.buttonMainForm);
            this.Name = "ExtendedEuclidForm";
            this.Text = "ExtendedEuclidForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeThisForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainForm;
        private System.Windows.Forms.Button startEuclid;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button binaryButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button zButton;
        private System.Windows.Forms.Button reset;
    }
}