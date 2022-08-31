
namespace Dialogo
{
    partial class Quiz : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.silverStarIcon = new System.Windows.Forms.PictureBox();
            this.blueStarIcon = new System.Windows.Forms.PictureBox();
            this.goldStarIcon = new System.Windows.Forms.PictureBox();
            this.word = new System.Windows.Forms.Label();
            this.word4 = new System.Windows.Forms.Label();
            this.word3 = new System.Windows.Forms.Label();
            this.word2 = new System.Windows.Forms.Label();
            this.word1 = new System.Windows.Forms.Label();
            this.word1BT = new System.Windows.Forms.RadioButton();
            this.word2BT = new System.Windows.Forms.RadioButton();
            this.word3BT = new System.Windows.Forms.RadioButton();
            this.word4BT = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submitBT = new System.Windows.Forms.PictureBox();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.amtLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.directionControl = new System.Windows.Forms.ComboBox();
            this.GameOver = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.engBox = new System.Windows.Forms.RichTextBox();
            this.ptbrBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverStarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueStarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldStarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitBT)).BeginInit();
            this.SuspendLayout();
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeIcon.BackgroundImage")));
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeIcon.Location = new System.Drawing.Point(692, 375);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(83, 69);
            this.homeIcon.TabIndex = 7;
            this.homeIcon.TabStop = false;
            this.homeIcon.Click += new System.EventHandler(this.homeIcon_Click);
            // 
            // silverStarIcon
            // 
            this.silverStarIcon.BackColor = System.Drawing.Color.Transparent;
            this.silverStarIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("silverStarIcon.BackgroundImage")));
            this.silverStarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.silverStarIcon.Location = new System.Drawing.Point(696, 327);
            this.silverStarIcon.Name = "silverStarIcon";
            this.silverStarIcon.Size = new System.Drawing.Size(79, 35);
            this.silverStarIcon.TabIndex = 6;
            this.silverStarIcon.TabStop = false;
            // 
            // blueStarIcon
            // 
            this.blueStarIcon.BackColor = System.Drawing.Color.Transparent;
            this.blueStarIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blueStarIcon.BackgroundImage")));
            this.blueStarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.blueStarIcon.Location = new System.Drawing.Point(634, 344);
            this.blueStarIcon.Name = "blueStarIcon";
            this.blueStarIcon.Size = new System.Drawing.Size(79, 35);
            this.blueStarIcon.TabIndex = 5;
            this.blueStarIcon.TabStop = false;
            // 
            // goldStarIcon
            // 
            this.goldStarIcon.BackColor = System.Drawing.Color.Transparent;
            this.goldStarIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goldStarIcon.BackgroundImage")));
            this.goldStarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goldStarIcon.Location = new System.Drawing.Point(608, 387);
            this.goldStarIcon.Name = "goldStarIcon";
            this.goldStarIcon.Size = new System.Drawing.Size(79, 35);
            this.goldStarIcon.TabIndex = 4;
            this.goldStarIcon.TabStop = false;
            // 
            // word
            // 
            this.word.BackColor = System.Drawing.Color.Black;
            this.word.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.word.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word.ForeColor = System.Drawing.Color.White;
            this.word.Location = new System.Drawing.Point(309, 60);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(183, 40);
            this.word.TabIndex = 19;
            this.word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word4
            // 
            this.word4.BackColor = System.Drawing.Color.Transparent;
            this.word4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.word4.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word4.ForeColor = System.Drawing.Color.White;
            this.word4.Location = new System.Drawing.Point(309, 305);
            this.word4.Name = "word4";
            this.word4.Size = new System.Drawing.Size(183, 40);
            this.word4.TabIndex = 18;
            this.word4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word3
            // 
            this.word3.BackColor = System.Drawing.Color.Transparent;
            this.word3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.word3.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word3.ForeColor = System.Drawing.Color.White;
            this.word3.Location = new System.Drawing.Point(309, 249);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(183, 40);
            this.word3.TabIndex = 17;
            this.word3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word2
            // 
            this.word2.BackColor = System.Drawing.Color.Transparent;
            this.word2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.word2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word2.ForeColor = System.Drawing.Color.White;
            this.word2.Location = new System.Drawing.Point(309, 190);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(183, 40);
            this.word2.TabIndex = 16;
            this.word2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word1
            // 
            this.word1.BackColor = System.Drawing.Color.Transparent;
            this.word1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.word1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word1.ForeColor = System.Drawing.Color.White;
            this.word1.Location = new System.Drawing.Point(309, 132);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(183, 40);
            this.word1.TabIndex = 15;
            this.word1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word1BT
            // 
            this.word1BT.AutoSize = true;
            this.word1BT.BackColor = System.Drawing.Color.Transparent;
            this.word1BT.Location = new System.Drawing.Point(274, 145);
            this.word1BT.Name = "word1BT";
            this.word1BT.Size = new System.Drawing.Size(14, 13);
            this.word1BT.TabIndex = 20;
            this.word1BT.TabStop = true;
            this.word1BT.UseVisualStyleBackColor = false;
            // 
            // word2BT
            // 
            this.word2BT.AutoSize = true;
            this.word2BT.BackColor = System.Drawing.Color.Transparent;
            this.word2BT.Location = new System.Drawing.Point(274, 203);
            this.word2BT.Name = "word2BT";
            this.word2BT.Size = new System.Drawing.Size(14, 13);
            this.word2BT.TabIndex = 21;
            this.word2BT.TabStop = true;
            this.word2BT.UseVisualStyleBackColor = false;
            // 
            // word3BT
            // 
            this.word3BT.AutoSize = true;
            this.word3BT.BackColor = System.Drawing.Color.Transparent;
            this.word3BT.Location = new System.Drawing.Point(274, 262);
            this.word3BT.Name = "word3BT";
            this.word3BT.Size = new System.Drawing.Size(14, 13);
            this.word3BT.TabIndex = 22;
            this.word3BT.TabStop = true;
            this.word3BT.UseVisualStyleBackColor = false;
            // 
            // word4BT
            // 
            this.word4BT.AutoSize = true;
            this.word4BT.BackColor = System.Drawing.Color.Transparent;
            this.word4BT.Location = new System.Drawing.Point(274, 316);
            this.word4BT.Name = "word4BT";
            this.word4BT.Size = new System.Drawing.Size(14, 13);
            this.word4BT.TabIndex = 23;
            this.word4BT.TabStop = true;
            this.word4BT.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(263, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 331);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // submitBT
            // 
            this.submitBT.BackColor = System.Drawing.Color.Transparent;
            this.submitBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitBT.BackgroundImage")));
            this.submitBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.submitBT.Location = new System.Drawing.Point(328, 366);
            this.submitBT.Name = "submitBT";
            this.submitBT.Size = new System.Drawing.Size(140, 75);
            this.submitBT.TabIndex = 25;
            this.submitBT.TabStop = false;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
            // 
            // remainingLabel
            // 
            this.remainingLabel.BackColor = System.Drawing.Color.Transparent;
            this.remainingLabel.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingLabel.ForeColor = System.Drawing.Color.White;
            this.remainingLabel.Location = new System.Drawing.Point(554, 23);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(210, 69);
            this.remainingLabel.TabIndex = 26;
            this.remainingLabel.Text = "Remaining:";
            this.remainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amtLabel
            // 
            this.amtLabel.BackColor = System.Drawing.Color.Transparent;
            this.amtLabel.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtLabel.ForeColor = System.Drawing.Color.White;
            this.amtLabel.Location = new System.Drawing.Point(575, 93);
            this.amtLabel.Name = "amtLabel";
            this.amtLabel.Size = new System.Drawing.Size(177, 53);
            this.amtLabel.TabIndex = 27;
            this.amtLabel.Text = "0";
            this.amtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(554, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 69);
            this.label1.TabIndex = 28;
            this.label1.Text = "Correct:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctLabel
            // 
            this.correctLabel.BackColor = System.Drawing.Color.Transparent;
            this.correctLabel.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.ForeColor = System.Drawing.Color.Lime;
            this.correctLabel.Location = new System.Drawing.Point(575, 203);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(177, 53);
            this.correctLabel.TabIndex = 29;
            this.correctLabel.Text = "0";
            this.correctLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directionControl
            // 
            this.directionControl.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionControl.ForeColor = System.Drawing.Color.DarkCyan;
            this.directionControl.FormattingEnabled = true;
            this.directionControl.Location = new System.Drawing.Point(309, 23);
            this.directionControl.Name = "directionControl";
            this.directionControl.Size = new System.Drawing.Size(183, 32);
            this.directionControl.TabIndex = 30;
            // 
            // GameOver
            // 
            this.GameOver.BackColor = System.Drawing.Color.Transparent;
            this.GameOver.Font = new System.Drawing.Font("Agency FB", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOver.ForeColor = System.Drawing.Color.White;
            this.GameOver.Location = new System.Drawing.Point(12, 9);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(781, 178);
            this.GameOver.TabIndex = 31;
            this.GameOver.Visible = false;
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.resultBox.Location = new System.Drawing.Point(12, 190);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(128, 254);
            this.resultBox.TabIndex = 32;
            this.resultBox.Text = "";
            // 
            // engBox
            // 
            this.engBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.engBox.Location = new System.Drawing.Point(146, 190);
            this.engBox.Name = "engBox";
            this.engBox.ReadOnly = true;
            this.engBox.Size = new System.Drawing.Size(128, 254);
            this.engBox.TabIndex = 33;
            this.engBox.Text = "";
            // 
            // ptbrBox
            // 
            this.ptbrBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptbrBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.ptbrBox.Location = new System.Drawing.Point(280, 190);
            this.ptbrBox.Name = "ptbrBox";
            this.ptbrBox.ReadOnly = true;
            this.ptbrBox.Size = new System.Drawing.Size(128, 254);
            this.ptbrBox.TabIndex = 34;
            this.ptbrBox.Text = "";
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.ptbrBox);
            this.Controls.Add(this.engBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.directionControl);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amtLabel);
            this.Controls.Add(this.remainingLabel);
            this.Controls.Add(this.submitBT);
            this.Controls.Add(this.word4BT);
            this.Controls.Add(this.word3BT);
            this.Controls.Add(this.word2BT);
            this.Controls.Add(this.word1BT);
            this.Controls.Add(this.word);
            this.Controls.Add(this.word4);
            this.Controls.Add(this.word3);
            this.Controls.Add(this.word2);
            this.Controls.Add(this.word1);
            this.Controls.Add(this.homeIcon);
            this.Controls.Add(this.silverStarIcon);
            this.Controls.Add(this.blueStarIcon);
            this.Controls.Add(this.goldStarIcon);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Quiz";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverStarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueStarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldStarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitBT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox silverStarIcon;
        private System.Windows.Forms.PictureBox blueStarIcon;
        private System.Windows.Forms.PictureBox goldStarIcon;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label word4;
        private System.Windows.Forms.Label word3;
        private System.Windows.Forms.Label word2;
        private System.Windows.Forms.Label word1;
        private System.Windows.Forms.RadioButton word1BT;
        private System.Windows.Forms.RadioButton word2BT;
        private System.Windows.Forms.RadioButton word3BT;
        private System.Windows.Forms.RadioButton word4BT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox submitBT;
        private System.Windows.Forms.Label remainingLabel;
        private System.Windows.Forms.Label amtLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.ComboBox directionControl;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.RichTextBox engBox;
        private System.Windows.Forms.RichTextBox ptbrBox;
    }
}