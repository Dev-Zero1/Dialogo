
namespace Dialogo
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.wordDGV = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.knownLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.knownAmtLabel = new System.Windows.Forms.Label();
            this.neverSeenAmtLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.randBT = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.playerIcon = new System.Windows.Forms.PictureBox();
            this.submitChangeBT = new System.Windows.Forms.PictureBox();
            this.playerName = new System.Windows.Forms.TextBox();
            this.editLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wordDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitChangeBT)).BeginInit();
            this.SuspendLayout();
            // 
            // wordDGV
            // 
            this.wordDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordDGV.Location = new System.Drawing.Point(684, 77);
            this.wordDGV.Name = "wordDGV";
            this.wordDGV.ReadOnly = true;
            this.wordDGV.Size = new System.Drawing.Size(261, 447);
            this.wordDGV.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(748, 26);
            this.searchBox.MaxLength = 60;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(185, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // knownLabel
            // 
            this.knownLabel.BackColor = System.Drawing.Color.Transparent;
            this.knownLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knownLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.knownLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.knownLabel.Location = new System.Drawing.Point(181, 450);
            this.knownLabel.Name = "knownLabel";
            this.knownLabel.Size = new System.Drawing.Size(126, 46);
            this.knownLabel.TabIndex = 4;
            this.knownLabel.Text = "Known:";
            this.knownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(115, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Never Seen:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // knownAmtLabel
            // 
            this.knownAmtLabel.BackColor = System.Drawing.Color.Transparent;
            this.knownAmtLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knownAmtLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.knownAmtLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.knownAmtLabel.Location = new System.Drawing.Point(313, 450);
            this.knownAmtLabel.Name = "knownAmtLabel";
            this.knownAmtLabel.Size = new System.Drawing.Size(85, 46);
            this.knownAmtLabel.TabIndex = 6;
            this.knownAmtLabel.Text = "0";
            this.knownAmtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // neverSeenAmtLabel
            // 
            this.neverSeenAmtLabel.BackColor = System.Drawing.Color.Transparent;
            this.neverSeenAmtLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neverSeenAmtLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.neverSeenAmtLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.neverSeenAmtLabel.Location = new System.Drawing.Point(313, 490);
            this.neverSeenAmtLabel.Name = "neverSeenAmtLabel";
            this.neverSeenAmtLabel.Size = new System.Drawing.Size(85, 46);
            this.neverSeenAmtLabel.TabIndex = 7;
            this.neverSeenAmtLabel.Text = "0";
            this.neverSeenAmtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(562, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 124);
            this.label2.TabIndex = 8;
            this.label2.Text = "View Reports";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // randBT
            // 
            this.randBT.BackColor = System.Drawing.Color.Transparent;
            this.randBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("randBT.BackgroundImage")));
            this.randBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.randBT.Location = new System.Drawing.Point(686, 5);
            this.randBT.Name = "randBT";
            this.randBT.Size = new System.Drawing.Size(56, 50);
            this.randBT.TabIndex = 9;
            this.randBT.TabStop = false;
            this.randBT.Click += new System.EventHandler(this.randBT_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.YellowGreen;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(391, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "/ 1000";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(391, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "/ 1000";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(78, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(511, 388);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(225, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 80);
            this.label5.TabIndex = 13;
            this.label5.Text = "START";
            this.label5.Click += new System.EventHandler(this.start_Click);
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerLabel.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.ForeColor = System.Drawing.Color.Transparent;
            this.PlayerLabel.Location = new System.Drawing.Point(94, 10);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(495, 42);
            this.PlayerLabel.TabIndex = 14;
            this.PlayerLabel.Text = "Hello Player!";
            this.PlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerIcon
            // 
            this.playerIcon.BackColor = System.Drawing.Color.Transparent;
            this.playerIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerIcon.BackgroundImage")));
            this.playerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerIcon.Location = new System.Drawing.Point(17, 12);
            this.playerIcon.Name = "playerIcon";
            this.playerIcon.Size = new System.Drawing.Size(47, 43);
            this.playerIcon.TabIndex = 15;
            this.playerIcon.TabStop = false;
            this.playerIcon.Click += new System.EventHandler(this.playerIcon_Click);
            // 
            // submitChangeBT
            // 
            this.submitChangeBT.BackColor = System.Drawing.Color.Transparent;
            this.submitChangeBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitChangeBT.BackgroundImage")));
            this.submitChangeBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.submitChangeBT.Location = new System.Drawing.Point(537, 12);
            this.submitChangeBT.Name = "submitChangeBT";
            this.submitChangeBT.Size = new System.Drawing.Size(52, 42);
            this.submitChangeBT.TabIndex = 16;
            this.submitChangeBT.TabStop = false;
            this.submitChangeBT.Click += new System.EventHandler(this.submitChangeBT_Click);
            // 
            // playerName
            // 
            this.playerName.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(227, 17);
            this.playerName.MaxLength = 20;
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(304, 30);
            this.playerName.TabIndex = 17;
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.BackColor = System.Drawing.Color.Transparent;
            this.editLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel.ForeColor = System.Drawing.Color.Transparent;
            this.editLabel.Location = new System.Drawing.Point(12, 58);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(58, 20);
            this.editLabel.TabIndex = 18;
            this.editLabel.Text = "Delete old";
            this.editLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Username";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 534);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.submitChangeBT);
            this.Controls.Add(this.playerIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.randBT);
            this.Controls.Add(this.neverSeenAmtLabel);
            this.Controls.Add(this.knownAmtLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.knownLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.wordDGV);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PlayerLabel);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Text = " Dialogo";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wordDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitChangeBT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView wordDGV;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label knownLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label knownAmtLabel;
        private System.Windows.Forms.Label neverSeenAmtLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox randBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.PictureBox playerIcon;
        private System.Windows.Forms.PictureBox submitChangeBT;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.Label label6;
    }
}