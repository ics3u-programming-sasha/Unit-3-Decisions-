namespace ControlObjectsSasha
{
    partial class frmControlObjects
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
            this.lblColour = new System.Windows.Forms.Label();
            this.btnColour = new System.Windows.Forms.Button();
            this.lstColour = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.BackColor = System.Drawing.Color.Transparent;
            this.lblColour.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(219, 61);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(316, 26);
            this.lblColour.TabIndex = 0;
            this.lblColour.Text = "Would you like to change colours?";
            this.lblColour.Click += new System.EventHandler(this.LblColour_Click);
            // 
            // btnColour
            // 
            this.btnColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColour.Location = new System.Drawing.Point(292, 124);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(154, 42);
            this.btnColour.TabIndex = 1;
            this.btnColour.Text = "Change Colours";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Click += new System.EventHandler(this.BtnColour_Click);
            // 
            // lstColour
            // 
            this.lstColour.FormattingEnabled = true;
            this.lstColour.Location = new System.Drawing.Point(247, 220);
            this.lstColour.Name = "lstColour";
            this.lstColour.Size = new System.Drawing.Size(249, 173);
            this.lstColour.TabIndex = 2;
            // 
            // frmControlObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstColour);
            this.Controls.Add(this.btnColour);
            this.Controls.Add(this.lblColour);
            this.Name = "frmControlObjects";
            this.Text = "For...Each with Control Objects by Sasha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Button btnColour;
        private System.Windows.Forms.ListBox lstColour;
    }
}

