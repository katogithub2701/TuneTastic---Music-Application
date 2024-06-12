namespace Music_Application
{
    partial class ucPlayListSong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPlayListSong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playBt = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Có Không Giữ Mất Đừng Tìm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(491, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Trúc Nhân";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(409, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(1333, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // playBt
            // 
            this.playBt.ActiveImage = null;
            this.playBt.AllowAnimations = true;
            this.playBt.AllowBuffering = false;
            this.playBt.AllowToggling = false;
            this.playBt.AllowZooming = true;
            this.playBt.AllowZoomingOnFocus = false;
            this.playBt.BackColor = System.Drawing.Color.Transparent;
            this.playBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.playBt.ErrorImage = ((System.Drawing.Image)(resources.GetObject("playBt.ErrorImage")));
            this.playBt.FadeWhenInactive = false;
            this.playBt.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.playBt.ForeColor = System.Drawing.Color.Transparent;
            this.playBt.Image = ((System.Drawing.Image)(resources.GetObject("playBt.Image")));
            this.playBt.ImageActive = null;
            this.playBt.ImageLocation = null;
            this.playBt.ImageMargin = 0;
            this.playBt.ImageSize = new System.Drawing.Size(31, 29);
            this.playBt.ImageZoomSize = new System.Drawing.Size(32, 30);
            this.playBt.InitialImage = ((System.Drawing.Image)(resources.GetObject("playBt.InitialImage")));
            this.playBt.Location = new System.Drawing.Point(1283, 17);
            this.playBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playBt.Name = "playBt";
            this.playBt.Rotation = 0;
            this.playBt.ShowActiveImage = true;
            this.playBt.ShowCursorChanges = true;
            this.playBt.ShowImageBorders = true;
            this.playBt.ShowSizeMarkers = false;
            this.playBt.Size = new System.Drawing.Size(32, 30);
            this.playBt.TabIndex = 20;
            this.playBt.ToolTipText = "";
            this.playBt.WaitOnLoad = false;
            this.playBt.Zoom = 0;
            this.playBt.ZoomSpeed = 10;
            this.playBt.Click += new System.EventHandler(this.playBt_Click);
            this.playBt.MouseEnter += new System.EventHandler(this.playBt_MouseEnter);
            this.playBt.MouseLeave += new System.EventHandler(this.playBt_MouseLeave);
            // 
            // ucPlayListSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.playBt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucPlayListSong";
            this.Size = new System.Drawing.Size(1393, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox3;
        public Bunifu.UI.WinForms.BunifuImageButton playBt;
    }
}
