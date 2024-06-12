namespace Music_Application
{
    partial class ucMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMusic));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewLabel = new System.Windows.Forms.Label();
            this.playBt = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.queueBt = new System.Windows.Forms.PictureBox();
            this.playlistBt = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Có Không Giữ Mất Đừng Tìm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(501, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trúc Nhân";
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLabel.ForeColor = System.Drawing.Color.White;
            this.viewLabel.Location = new System.Drawing.Point(952, 22);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(40, 18);
            this.viewLabel.TabIndex = 7;
            this.viewLabel.Text = "1000";
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
            this.playBt.Image = global::Music_Application.Properties.Resources.wplay;
            this.playBt.ImageActive = null;
            this.playBt.ImageLocation = null;
            this.playBt.ImageMargin = 0;
            this.playBt.ImageSize = new System.Drawing.Size(31, 29);
            this.playBt.ImageZoomSize = new System.Drawing.Size(32, 30);
            this.playBt.InitialImage = ((System.Drawing.Image)(resources.GetObject("playBt.InitialImage")));
            this.playBt.Location = new System.Drawing.Point(1241, 17);
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
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(924, 18);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 23);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // queueBt
            // 
            this.queueBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("queueBt.BackgroundImage")));
            this.queueBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.queueBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queueBt.Location = new System.Drawing.Point(1291, 17);
            this.queueBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queueBt.Name = "queueBt";
            this.queueBt.Size = new System.Drawing.Size(32, 30);
            this.queueBt.TabIndex = 5;
            this.queueBt.TabStop = false;
            this.queueBt.Click += new System.EventHandler(this.queueBt_Click);
            // 
            // playlistBt
            // 
            this.playlistBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playlistBt.BackgroundImage")));
            this.playlistBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playlistBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistBt.Location = new System.Drawing.Point(1337, 17);
            this.playlistBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playlistBt.Name = "playlistBt";
            this.playlistBt.Size = new System.Drawing.Size(32, 30);
            this.playlistBt.TabIndex = 4;
            this.playlistBt.TabStop = false;
            this.playlistBt.Click += new System.EventHandler(this.playlistBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(23, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.playBt);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.queueBt);
            this.Controls.Add(this.playlistBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucMusic";
            this.Size = new System.Drawing.Size(1393, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox playlistBt;
        private System.Windows.Forms.PictureBox queueBt;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label viewLabel;
        public Bunifu.UI.WinForms.BunifuImageButton playBt;
    }
}
