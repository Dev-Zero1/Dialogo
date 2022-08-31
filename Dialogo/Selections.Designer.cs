
namespace Dialogo
{
    partial class Selections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selections));
            this.homeBT = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.wordFilter = new System.Windows.Forms.ComboBox();
            this.gameFilter = new System.Windows.Forms.ComboBox();
            this.amountFilter = new System.Windows.Forms.NumericUpDown();
            this.goPIC = new System.Windows.Forms.PictureBox();
            this.goLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.homeBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // homeBT
            // 
            this.homeBT.BackColor = System.Drawing.Color.Transparent;
            this.homeBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBT.BackgroundImage")));
            this.homeBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeBT.Location = new System.Drawing.Point(130, 12);
            this.homeBT.Name = "homeBT";
            this.homeBT.Size = new System.Drawing.Size(81, 56);
            this.homeBT.TabIndex = 0;
            this.homeBT.TabStop = false;
            this.homeBT.Click += new System.EventHandler(this.homeBT_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(68, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 71);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // wordFilter
            // 
            this.wordFilter.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordFilter.ForeColor = System.Drawing.Color.DarkCyan;
            this.wordFilter.FormattingEnabled = true;
            this.wordFilter.Location = new System.Drawing.Point(91, 74);
            this.wordFilter.Name = "wordFilter";
            this.wordFilter.Size = new System.Drawing.Size(161, 42);
            this.wordFilter.TabIndex = 4;
            this.wordFilter.TextUpdate += new System.EventHandler(this.wordFilter_TextUpdate);
            // 
            // gameFilter
            // 
            this.gameFilter.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameFilter.ForeColor = System.Drawing.Color.DarkCyan;
            this.gameFilter.FormattingEnabled = true;
            this.gameFilter.Location = new System.Drawing.Point(91, 140);
            this.gameFilter.Name = "gameFilter";
            this.gameFilter.Size = new System.Drawing.Size(161, 42);
            this.gameFilter.TabIndex = 5;
            this.gameFilter.SelectedIndexChanged += new System.EventHandler(this.gameFilter_SelectedIndexChanged);
            this.gameFilter.TextUpdate += new System.EventHandler(this.gameFilter_TextUpdate);
            // 
            // amountFilter
            // 
            this.amountFilter.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountFilter.ForeColor = System.Drawing.Color.DarkCyan;
            this.amountFilter.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountFilter.Location = new System.Drawing.Point(91, 206);
            this.amountFilter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.amountFilter.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountFilter.Name = "amountFilter";
            this.amountFilter.ReadOnly = true;
            this.amountFilter.Size = new System.Drawing.Size(161, 40);
            this.amountFilter.TabIndex = 6;
            this.amountFilter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.amountFilter.ValueChanged += new System.EventHandler(this.amountFilter_ValueChanged);
            // 
            // goPIC
            // 
            this.goPIC.BackColor = System.Drawing.Color.Transparent;
            this.goPIC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goPIC.BackgroundImage")));
            this.goPIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goPIC.Location = new System.Drawing.Point(102, 269);
            this.goPIC.Name = "goPIC";
            this.goPIC.Size = new System.Drawing.Size(134, 100);
            this.goPIC.TabIndex = 7;
            this.goPIC.TabStop = false;
            this.goPIC.Click += new System.EventHandler(this.goPIC_Click);
            // 
            // goLabel
            // 
            this.goLabel.BackColor = System.Drawing.Color.Transparent;
            this.goLabel.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLabel.ForeColor = System.Drawing.Color.White;
            this.goLabel.Location = new System.Drawing.Point(145, 357);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(55, 24);
            this.goLabel.TabIndex = 8;
            this.goLabel.Text = "GO!";
            this.goLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goLabel.Click += new System.EventHandler(this.goLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(68, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 71);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(68, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 71);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // Selections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(342, 395);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.goPIC);
            this.Controls.Add(this.amountFilter);
            this.Controls.Add(this.gameFilter);
            this.Controls.Add(this.wordFilter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.homeBT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.Name = "Selections";
            this.Text = "selections";
            ((System.ComponentModel.ISupportInitialize)(this.homeBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox homeBT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox wordFilter;
        private System.Windows.Forms.ComboBox gameFilter;
        private System.Windows.Forms.NumericUpDown amountFilter;
        private System.Windows.Forms.PictureBox goPIC;
        private System.Windows.Forms.Label goLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}