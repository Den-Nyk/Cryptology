namespace Cryptology.AllForms
{
    partial class JacobianSymbolForm
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
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.isPrime = new System.Windows.Forms.Button();
            this.JacobiSymbol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMainForm
            // 
            this.buttonMainForm.Location = new System.Drawing.Point(12, 395);
            this.buttonMainForm.Name = "buttonMainForm";
            this.buttonMainForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMainForm.Size = new System.Drawing.Size(427, 43);
            this.buttonMainForm.TabIndex = 1;
            this.buttonMainForm.Text = "Main form";
            this.buttonMainForm.UseVisualStyleBackColor = true;
            this.buttonMainForm.Click += new System.EventHandler(this.buttonMainForm_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(12, 12);
            this.AnswerBox.Multiline = true;
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(427, 377);
            this.AnswerBox.TabIndex = 2;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(445, 334);
            this.reset.Name = "reset";
            this.reset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reset.Size = new System.Drawing.Size(343, 104);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // isPrime
            // 
            this.isPrime.Location = new System.Drawing.Point(445, 169);
            this.isPrime.Name = "isPrime";
            this.isPrime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.isPrime.Size = new System.Drawing.Size(343, 104);
            this.isPrime.TabIndex = 4;
            this.isPrime.Text = "Check prime";
            this.isPrime.UseVisualStyleBackColor = true;
            this.isPrime.Click += new System.EventHandler(this.isPrime_Click);
            // 
            // JacobiSymbol
            // 
            this.JacobiSymbol.Location = new System.Drawing.Point(445, 12);
            this.JacobiSymbol.Name = "JacobiSymbol";
            this.JacobiSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.JacobiSymbol.Size = new System.Drawing.Size(343, 104);
            this.JacobiSymbol.TabIndex = 5;
            this.JacobiSymbol.Text = "Jacobi Symbol";
            this.JacobiSymbol.UseVisualStyleBackColor = true;
            this.JacobiSymbol.Click += new System.EventHandler(this.JacobiSymbol_Click);
            // 
            // JacobianSymbolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JacobiSymbol);
            this.Controls.Add(this.isPrime);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.buttonMainForm);
            this.Name = "JacobianSymbolForm";
            this.Text = "JacobianSymbolForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeThisForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainForm;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button isPrime;
        private System.Windows.Forms.Button JacobiSymbol;
    }
}