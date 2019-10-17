namespace FactWithForLoopSasha
{
    partial class frmFactWithForLoop
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
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstFactorialNumbers = new System.Windows.Forms.ListBox();
            this.lblFactorialAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNumber.Location = new System.Drawing.Point(193, 70);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(187, 28);
            this.lblEnterNumber.TabIndex = 0;
            this.lblEnterNumber.Text = "Enter the number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(430, 78);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(318, 158);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 38);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lstFactorialNumbers
            // 
            this.lstFactorialNumbers.FormattingEnabled = true;
            this.lstFactorialNumbers.Location = new System.Drawing.Point(281, 233);
            this.lstFactorialNumbers.Name = "lstFactorialNumbers";
            this.lstFactorialNumbers.Size = new System.Drawing.Size(187, 134);
            this.lstFactorialNumbers.TabIndex = 3;
            // 
            // lblFactorialAnswer
            // 
            this.lblFactorialAnswer.AutoSize = true;
            this.lblFactorialAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactorialAnswer.Location = new System.Drawing.Point(327, 396);
            this.lblFactorialAnswer.Name = "lblFactorialAnswer";
            this.lblFactorialAnswer.Size = new System.Drawing.Size(0, 25);
            this.lblFactorialAnswer.TabIndex = 4;
            // 
            // frmFactWithForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFactorialAnswer);
            this.Controls.Add(this.lstFactorialNumbers);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblEnterNumber);
            this.Name = "frmFactWithForLoop";
            this.Text = "Factorial with For Loop by Sasha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstFactorialNumbers;
        private System.Windows.Forms.Label lblFactorialAnswer;
    }
}

