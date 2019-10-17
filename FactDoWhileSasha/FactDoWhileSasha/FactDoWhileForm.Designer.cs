namespace FactDoWhileSasha
{
    partial class frmFactDoWhile
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
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lstFactorialNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(59, 56);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(672, 30);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "What number would you like to perform a factorial calculation on?";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(328, 120);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(319, 169);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(118, 33);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(334, 383);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 30);
            this.lblAnswer.TabIndex = 3;
            // 
            // lstFactorialNumbers
            // 
            this.lstFactorialNumbers.FormattingEnabled = true;
            this.lstFactorialNumbers.Location = new System.Drawing.Point(287, 227);
            this.lstFactorialNumbers.Name = "lstFactorialNumbers";
            this.lstFactorialNumbers.Size = new System.Drawing.Size(180, 121);
            this.lstFactorialNumbers.TabIndex = 4;
            // 
            // frmFactDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFactorialNumbers);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblValue);
            this.Name = "frmFactDoWhile";
            this.Text = "Factorial Do While by Sasha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ListBox lstFactorialNumbers;
    }
}

