namespace RockPaperScissorsSasha
{
    partial class frmRockPaperScissors
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
            this.lblUChoice = new System.Windows.Forms.Label();
            this.lblCChoice = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.picCChoice = new System.Windows.Forms.PictureBox();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUChoice
            // 
            this.lblUChoice.AutoSize = true;
            this.lblUChoice.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUChoice.Location = new System.Drawing.Point(26, 25);
            this.lblUChoice.Name = "lblUChoice";
            this.lblUChoice.Size = new System.Drawing.Size(291, 26);
            this.lblUChoice.TabIndex = 0;
            this.lblUChoice.Text = "Choose rock, paper, or scissors:";
            // 
            // lblCChoice
            // 
            this.lblCChoice.AutoSize = true;
            this.lblCChoice.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.lblCChoice.Location = new System.Drawing.Point(474, 25);
            this.lblCChoice.Name = "lblCChoice";
            this.lblCChoice.Size = new System.Drawing.Size(238, 26);
            this.lblCChoice.TabIndex = 4;
            this.lblCChoice.Text = "The computer\'s choice is:";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(474, 372);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(42, 26);
            this.lblWinner.TabIndex = 5;
            this.lblWinner.Text = "???";
            // 
            // picCChoice
            // 
            this.picCChoice.Image = global::RockPaperScissorsSasha.Properties.Resources.Rock;
            this.picCChoice.Location = new System.Drawing.Point(531, 148);
            this.picCChoice.Name = "picCChoice";
            this.picCChoice.Size = new System.Drawing.Size(216, 131);
            this.picCChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCChoice.TabIndex = 6;
            this.picCChoice.TabStop = false;
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.radRock.Location = new System.Drawing.Point(57, 110);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(75, 30);
            this.radRock.TabIndex = 7;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            // 
            // picRock
            // 
            this.picRock.Image = global::RockPaperScissorsSasha.Properties.Resources.Rock;
            this.picRock.Location = new System.Drawing.Point(191, 92);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(102, 64);
            this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRock.TabIndex = 8;
            this.picRock.TabStop = false;
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.radPaper.Location = new System.Drawing.Point(57, 233);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(82, 30);
            this.radPaper.TabIndex = 9;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            // 
            // picPaper
            // 
            this.picPaper.Image = global::RockPaperScissorsSasha.Properties.Resources.Paper;
            this.picPaper.Location = new System.Drawing.Point(191, 215);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(102, 64);
            this.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaper.TabIndex = 10;
            this.picPaper.TabStop = false;
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.radScissors.Location = new System.Drawing.Point(57, 353);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(103, 30);
            this.radScissors.TabIndex = 11;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            // 
            // picScissors
            // 
            this.picScissors.Image = global::RockPaperScissorsSasha.Properties.Resources.Scissors;
            this.picScissors.Location = new System.Drawing.Point(191, 334);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(102, 64);
            this.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScissors.TabIndex = 12;
            this.picScissors.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(354, 225);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 45);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.radScissors);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.radPaper);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.radRock);
            this.Controls.Add(this.picCChoice);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblCChoice);
            this.Controls.Add(this.lblUChoice);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.picCChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUChoice;
        private System.Windows.Forms.Label lblCChoice;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox picCChoice;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.Button btnSubmit;
    }
}

