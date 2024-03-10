namespace CSC240_0902_RockPaperScissors_PMM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            UxTitleLabel = new Label();
            UxComputerPictureBox = new PictureBox();
            UxPlayerPictureBox = new PictureBox();
            UxRock = new PictureBox();
            UxPaper = new PictureBox();
            UxScissor = new PictureBox();
            label1 = new Label();
            UxPlayerScore = new Label();
            UxComputerScore = new Label();
            ((System.ComponentModel.ISupportInitialize)UxComputerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UxPlayerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UxRock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UxPaper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UxScissor).BeginInit();
            SuspendLayout();
            // 
            // UxTitleLabel
            // 
            UxTitleLabel.AutoSize = true;
            UxTitleLabel.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UxTitleLabel.Location = new Point(280, 41);
            UxTitleLabel.Name = "UxTitleLabel";
            UxTitleLabel.Size = new Size(522, 36);
            UxTitleLabel.TabIndex = 0;
            UxTitleLabel.Text = "Lets play rock paper scissors!!!";
            // 
            // UxComputerPictureBox
            // 
            UxComputerPictureBox.Location = new Point(677, 142);
            UxComputerPictureBox.Name = "UxComputerPictureBox";
            UxComputerPictureBox.Size = new Size(244, 266);
            UxComputerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UxComputerPictureBox.TabIndex = 1;
            UxComputerPictureBox.TabStop = false;
            // 
            // UxPlayerPictureBox
            // 
            UxPlayerPictureBox.Location = new Point(125, 142);
            UxPlayerPictureBox.Name = "UxPlayerPictureBox";
            UxPlayerPictureBox.Size = new Size(244, 266);
            UxPlayerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UxPlayerPictureBox.TabIndex = 1;
            UxPlayerPictureBox.TabStop = false;
            // 
            // UxRock
            // 
            UxRock.Image = (Image)resources.GetObject("UxRock.Image");
            UxRock.Location = new Point(250, 537);
            UxRock.Name = "UxRock";
            UxRock.Size = new Size(147, 103);
            UxRock.SizeMode = PictureBoxSizeMode.StretchImage;
            UxRock.TabIndex = 2;
            UxRock.TabStop = false;
            UxRock.Click += UxRock_Click;
            // 
            // UxPaper
            // 
            UxPaper.Image = (Image)resources.GetObject("UxPaper.Image");
            UxPaper.Location = new Point(449, 537);
            UxPaper.Name = "UxPaper";
            UxPaper.Size = new Size(147, 103);
            UxPaper.SizeMode = PictureBoxSizeMode.StretchImage;
            UxPaper.TabIndex = 2;
            UxPaper.TabStop = false;
            UxPaper.Click += UxPaper_Click;
            // 
            // UxScissor
            // 
            UxScissor.Image = (Image)resources.GetObject("UxScissor.Image");
            UxScissor.Location = new Point(655, 537);
            UxScissor.Name = "UxScissor";
            UxScissor.Size = new Size(147, 103);
            UxScissor.SizeMode = PictureBoxSizeMode.StretchImage;
            UxScissor.TabIndex = 2;
            UxScissor.TabStop = false;
            UxScissor.Click += UxScissor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(412, 474);
            label1.Name = "label1";
            label1.Size = new Size(228, 23);
            label1.TabIndex = 3;
            label1.Text = "Make your selection.";
            // 
            // UxPlayerScore
            // 
            UxPlayerScore.AutoSize = true;
            UxPlayerScore.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UxPlayerScore.Location = new Point(412, 251);
            UxPlayerScore.Name = "UxPlayerScore";
            UxPlayerScore.Size = new Size(31, 33);
            UxPlayerScore.TabIndex = 4;
            UxPlayerScore.Text = "0";
            // 
            // UxComputerScore
            // 
            UxComputerScore.AutoSize = true;
            UxComputerScore.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UxComputerScore.Location = new Point(600, 251);
            UxComputerScore.Name = "UxComputerScore";
            UxComputerScore.Size = new Size(31, 33);
            UxComputerScore.TabIndex = 4;
            UxComputerScore.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1000, 680);
            Controls.Add(UxComputerScore);
            Controls.Add(UxPlayerScore);
            Controls.Add(label1);
            Controls.Add(UxScissor);
            Controls.Add(UxPaper);
            Controls.Add(UxRock);
            Controls.Add(UxPlayerPictureBox);
            Controls.Add(UxComputerPictureBox);
            Controls.Add(UxTitleLabel);
            Name = "Form1";
            Text = "Rock Paper Scissors";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)UxComputerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)UxPlayerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)UxRock).EndInit();
            ((System.ComponentModel.ISupportInitialize)UxPaper).EndInit();
            ((System.ComponentModel.ISupportInitialize)UxScissor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UxTitleLabel;
        private PictureBox UxComputerPictureBox;
        private PictureBox UxPlayerPictureBox;
        private PictureBox UxRock;
        private PictureBox UxPaper;
        private PictureBox UxScissor;
        private Label label1;
        private Label UxPlayerScore;
        private Label UxComputerScore;
    }
}
