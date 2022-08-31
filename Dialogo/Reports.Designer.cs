
namespace Dialogo
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.reportSelection = new System.Windows.Forms.ComboBox();
            this.reportDGV = new System.Windows.Forms.DataGridView();
            this.homeBT = new System.Windows.Forms.PictureBox();
            this.zeroNotification1 = new System.Windows.Forms.Label();
            this.zeroNotification2 = new System.Windows.Forms.Label();
            this.resetBT = new System.Windows.Forms.PictureBox();
            this.resetLabel = new System.Windows.Forms.Label();
            this.seenAllBT = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetBT)).BeginInit();
            this.SuspendLayout();
            // 
            // reportSelection
            // 
            this.reportSelection.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportSelection.FormattingEnabled = true;
            this.reportSelection.Location = new System.Drawing.Point(57, 9);
            this.reportSelection.Name = "reportSelection";
            this.reportSelection.Size = new System.Drawing.Size(385, 33);
            this.reportSelection.TabIndex = 0;
            this.reportSelection.SelectedIndexChanged += new System.EventHandler(this.reportSelection_SelectedIndexChanged);
            // 
            // reportDGV
            // 
            this.reportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDGV.Location = new System.Drawing.Point(57, 47);
            this.reportDGV.Name = "reportDGV";
            this.reportDGV.Size = new System.Drawing.Size(385, 457);
            this.reportDGV.TabIndex = 1;
            // 
            // homeBT
            // 
            this.homeBT.BackColor = System.Drawing.Color.Transparent;
            this.homeBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBT.BackgroundImage")));
            this.homeBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeBT.Location = new System.Drawing.Point(445, 452);
            this.homeBT.Name = "homeBT";
            this.homeBT.Size = new System.Drawing.Size(50, 52);
            this.homeBT.TabIndex = 2;
            this.homeBT.TabStop = false;
            this.homeBT.Click += new System.EventHandler(this.homeBT_Click);
            // 
            // zeroNotification1
            // 
            this.zeroNotification1.BackColor = System.Drawing.Color.Transparent;
            this.zeroNotification1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroNotification1.ForeColor = System.Drawing.Color.White;
            this.zeroNotification1.Location = new System.Drawing.Point(0, 134);
            this.zeroNotification1.Name = "zeroNotification1";
            this.zeroNotification1.Size = new System.Drawing.Size(495, 47);
            this.zeroNotification1.TabIndex = 3;
            this.zeroNotification1.Text = "It doesn\'t look like we have enough data yet!";
            this.zeroNotification1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.zeroNotification1.Visible = false;
            // 
            // zeroNotification2
            // 
            this.zeroNotification2.BackColor = System.Drawing.Color.Transparent;
            this.zeroNotification2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroNotification2.ForeColor = System.Drawing.Color.White;
            this.zeroNotification2.Location = new System.Drawing.Point(57, 191);
            this.zeroNotification2.Name = "zeroNotification2";
            this.zeroNotification2.Size = new System.Drawing.Size(385, 41);
            this.zeroNotification2.TabIndex = 4;
            this.zeroNotification2.Text = "Please try a quiz or flashcard!";
            this.zeroNotification2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.zeroNotification2.Visible = false;
            // 
            // resetBT
            // 
            this.resetBT.BackColor = System.Drawing.Color.Transparent;
            this.resetBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetBT.BackgroundImage")));
            this.resetBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resetBT.Location = new System.Drawing.Point(127, 235);
            this.resetBT.Name = "resetBT";
            this.resetBT.Size = new System.Drawing.Size(234, 91);
            this.resetBT.TabIndex = 5;
            this.resetBT.TabStop = false;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click);
            // 
            // resetLabel
            // 
            this.resetLabel.BackColor = System.Drawing.Color.Transparent;
            this.resetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resetLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetLabel.ForeColor = System.Drawing.Color.White;
            this.resetLabel.Location = new System.Drawing.Point(143, 262);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(204, 41);
            this.resetLabel.TabIndex = 6;
            this.resetLabel.Text = "Reset Everything";
            this.resetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetLabel.Visible = false;
            this.resetLabel.Click += new System.EventHandler(this.resetLabel_Click);
            // 
            // seenAllBT
            // 
            this.seenAllBT.BackColor = System.Drawing.Color.Transparent;
            this.seenAllBT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seenAllBT.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seenAllBT.ForeColor = System.Drawing.Color.White;
            this.seenAllBT.Location = new System.Drawing.Point(143, 551);
            this.seenAllBT.Name = "seenAllBT";
            this.seenAllBT.Size = new System.Drawing.Size(204, 31);
            this.seenAllBT.TabIndex = 7;
            this.seenAllBT.Text = "I know ALL of these!";
            this.seenAllBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.seenAllBT.Visible = false;
            this.seenAllBT.Click += new System.EventHandler(this.seenAllBT_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(57, 16);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(385, 23);
            this.title.TabIndex = 8;
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(57, 507);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(385, 23);
            this.time.TabIndex = 9;
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(497, 586);
            this.Controls.Add(this.time);
            this.Controls.Add(this.resetLabel);
            this.Controls.Add(this.seenAllBT);
            this.Controls.Add(this.resetBT);
            this.Controls.Add(this.zeroNotification2);
            this.Controls.Add(this.zeroNotification1);
            this.Controls.Add(this.reportDGV);
            this.Controls.Add(this.homeBT);
            this.Controls.Add(this.reportSelection);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox reportSelection;
        private System.Windows.Forms.DataGridView reportDGV;
        private System.Windows.Forms.PictureBox homeBT;
        private System.Windows.Forms.Label zeroNotification1;
        private System.Windows.Forms.Label zeroNotification2;
        private System.Windows.Forms.PictureBox resetBT;
        private System.Windows.Forms.Label resetLabel;
        private System.Windows.Forms.Label seenAllBT;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label time;
    }
}