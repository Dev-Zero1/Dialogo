
namespace Dialogo
{
    partial class Flashcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flashcard));
            this.remainingLabel = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.nextBT = new System.Windows.Forms.PictureBox();
            this.prevBT = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nextBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // remainingLabel
            // 
            this.remainingLabel.BackColor = System.Drawing.Color.Transparent;
            this.remainingLabel.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingLabel.ForeColor = System.Drawing.Color.White;
            this.remainingLabel.Location = new System.Drawing.Point(237, 338);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(315, 45);
            this.remainingLabel.TabIndex = 8;
            this.remainingLabel.Text = "Flashcards Remaining:";
            this.remainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordLabel
            // 
            this.wordLabel.BackColor = System.Drawing.Color.Black;
            this.wordLabel.Font = new System.Drawing.Font("Agency FB", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.ForeColor = System.Drawing.Color.White;
            this.wordLabel.Location = new System.Drawing.Point(86, 100);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(627, 90);
            this.wordLabel.TabIndex = 5;
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordLabel.Click += new System.EventHandler(this.wordLabel_Click);
            // 
            // nextBT
            // 
            this.nextBT.BackColor = System.Drawing.Color.Transparent;
            this.nextBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextBT.BackgroundImage")));
            this.nextBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextBT.Location = new System.Drawing.Point(452, 283);
            this.nextBT.Name = "nextBT";
            this.nextBT.Size = new System.Drawing.Size(100, 50);
            this.nextBT.TabIndex = 7;
            this.nextBT.TabStop = false;
            this.nextBT.Click += new System.EventHandler(this.nextBT_Click);
            // 
            // prevBT
            // 
            this.prevBT.BackColor = System.Drawing.Color.Transparent;
            this.prevBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prevBT.BackgroundImage")));
            this.prevBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prevBT.Location = new System.Drawing.Point(237, 283);
            this.prevBT.Name = "prevBT";
            this.prevBT.Size = new System.Drawing.Size(100, 50);
            this.prevBT.TabIndex = 6;
            this.prevBT.TabStop = false;
            this.prevBT.Click += new System.EventHandler(this.prevBT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(24, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 275);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeIcon.BackgroundImage")));
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeIcon.Location = new System.Drawing.Point(692, 375);
            this.homeIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(83, 69);
            this.homeIcon.TabIndex = 3;
            this.homeIcon.TabStop = false;
            this.homeIcon.Click += new System.EventHandler(this.homeIcon_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Go Again!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Flashcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remainingLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.nextBT);
            this.Controls.Add(this.prevBT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.homeIcon);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Flashcard";
            this.Text = "Flashcard";
            ((System.ComponentModel.ISupportInitialize)(this.nextBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.PictureBox prevBT;
        private System.Windows.Forms.PictureBox nextBT;
        private System.Windows.Forms.Label remainingLabel;
        private System.Windows.Forms.Label label1;
    }
}