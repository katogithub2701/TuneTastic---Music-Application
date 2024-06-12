namespace Music_Application.UC
{
    partial class ucPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPlayer));
            this.playButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.loopButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.musicSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.queueButton = new System.Windows.Forms.Button();
            this.currentLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.musicNameLabel = new System.Windows.Forms.Label();
            this.artistNameLabel = new System.Windows.Forms.Label();
            this.volumnButton = new System.Windows.Forms.Button();
            this.volumnSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.ActiveImage = null;
            this.playButton.AllowAnimations = true;
            this.playButton.AllowBuffering = false;
            this.playButton.AllowToggling = false;
            this.playButton.AllowZooming = true;
            this.playButton.AllowZoomingOnFocus = false;
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.playButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.playButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("playButton.ErrorImage")));
            this.playButton.FadeWhenInactive = false;
            this.playButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.playButton.ForeColor = System.Drawing.Color.Transparent;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.ImageActive = null;
            this.playButton.ImageLocation = null;
            this.playButton.ImageMargin = 0;
            this.playButton.ImageSize = new System.Drawing.Size(27, 27);
            this.playButton.ImageZoomSize = new System.Drawing.Size(28, 28);
            this.playButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("playButton.InitialImage")));
            this.playButton.Location = new System.Drawing.Point(629, 11);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Rotation = 0;
            this.playButton.ShowActiveImage = true;
            this.playButton.ShowCursorChanges = true;
            this.playButton.ShowImageBorders = true;
            this.playButton.ShowSizeMarkers = false;
            this.playButton.Size = new System.Drawing.Size(28, 28);
            this.playButton.TabIndex = 18;
            this.playButton.ToolTipText = "";
            this.playButton.WaitOnLoad = false;
            this.playButton.Zoom = 0;
            this.playButton.ZoomSpeed = 10;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.BackColor = System.Drawing.Color.Transparent;
            this.shuffleButton.BackgroundImage = global::Music_Application.Properties.Resources.wshuffle;
            this.shuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shuffleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shuffleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.shuffleButton.FlatAppearance.BorderSize = 0;
            this.shuffleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shuffleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleButton.ForeColor = System.Drawing.Color.Transparent;
            this.shuffleButton.Location = new System.Drawing.Point(553, 11);
            this.shuffleButton.Margin = new System.Windows.Forms.Padding(2);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(26, 28);
            this.shuffleButton.TabIndex = 22;
            this.shuffleButton.UseVisualStyleBackColor = false;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // loopButton
            // 
            this.loopButton.BackColor = System.Drawing.Color.Transparent;
            this.loopButton.BackgroundImage = global::Music_Application.Properties.Resources.wrepeat;
            this.loopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loopButton.FlatAppearance.BorderSize = 0;
            this.loopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loopButton.ForeColor = System.Drawing.Color.Transparent;
            this.loopButton.Location = new System.Drawing.Point(710, 11);
            this.loopButton.Margin = new System.Windows.Forms.Padding(2);
            this.loopButton.Name = "loopButton";
            this.loopButton.Size = new System.Drawing.Size(26, 28);
            this.loopButton.TabIndex = 21;
            this.loopButton.UseVisualStyleBackColor = false;
            this.loopButton.Click += new System.EventHandler(this.loopButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.ForeColor = System.Drawing.Color.Transparent;
            this.nextButton.Location = new System.Drawing.Point(668, 11);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(26, 26);
            this.nextButton.TabIndex = 20;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.Transparent;
            this.previousButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousButton.BackgroundImage")));
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.previousButton.FlatAppearance.BorderSize = 0;
            this.previousButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.previousButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.ForeColor = System.Drawing.Color.Transparent;
            this.previousButton.Location = new System.Drawing.Point(592, 11);
            this.previousButton.Margin = new System.Windows.Forms.Padding(2);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(26, 26);
            this.previousButton.TabIndex = 19;
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // musicSlider
            // 
            this.musicSlider.AllowCursorChanges = true;
            this.musicSlider.AllowHomeEndKeysDetection = false;
            this.musicSlider.AllowIncrementalClickMoves = true;
            this.musicSlider.AllowMouseDownEffects = false;
            this.musicSlider.AllowMouseHoverEffects = false;
            this.musicSlider.AllowScrollingAnimations = true;
            this.musicSlider.AllowScrollKeysDetection = true;
            this.musicSlider.AllowScrollOptionsMenu = true;
            this.musicSlider.AllowShrinkingOnFocusLost = false;
            this.musicSlider.BackColor = System.Drawing.Color.Transparent;
            this.musicSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musicSlider.BackgroundImage")));
            this.musicSlider.BindingContainer = null;
            this.musicSlider.BorderRadius = 2;
            this.musicSlider.BorderThickness = 1;
            this.musicSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicSlider.DrawThickBorder = true;
            this.musicSlider.DurationBeforeShrink = 2000;
            this.musicSlider.ElapsedColor = System.Drawing.Color.LightSeaGreen;
            this.musicSlider.LargeChange = 10;
            this.musicSlider.Location = new System.Drawing.Point(357, 40);
            this.musicSlider.Margin = new System.Windows.Forms.Padding(4);
            this.musicSlider.Maximum = 100;
            this.musicSlider.Minimum = 0;
            this.musicSlider.MinimumSize = new System.Drawing.Size(0, 25);
            this.musicSlider.MinimumThumbLength = 18;
            this.musicSlider.Name = "musicSlider";
            this.musicSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.musicSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.musicSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.musicSlider.ScrollBarBorderColor = System.Drawing.Color.White;
            this.musicSlider.ScrollBarColor = System.Drawing.Color.White;
            this.musicSlider.ShrinkSizeLimit = 3;
            this.musicSlider.Size = new System.Drawing.Size(555, 32);
            this.musicSlider.SliderColor = System.Drawing.Color.White;
            this.musicSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thick;
            this.musicSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.musicSlider.SmallChange = 1;
            this.musicSlider.TabIndex = 23;
            this.musicSlider.ThumbColor = System.Drawing.Color.Ivory;
            this.musicSlider.ThumbFillColor = System.Drawing.Color.LightSeaGreen;
            this.musicSlider.ThumbLength = 55;
            this.musicSlider.ThumbMargin = 1;
            this.musicSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.musicSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.musicSlider.Value = 0;
            this.musicSlider.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.musicSlider_Scroll);
            this.musicSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.musicSlider_MouseDown);
            this.musicSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.musicSlider_MouseUp);
            // 
            // queueButton
            // 
            this.queueButton.BackColor = System.Drawing.Color.Transparent;
            this.queueButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("queueButton.BackgroundImage")));
            this.queueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.queueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queueButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.queueButton.FlatAppearance.BorderSize = 0;
            this.queueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.queueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.queueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queueButton.ForeColor = System.Drawing.Color.Transparent;
            this.queueButton.Location = new System.Drawing.Point(1228, 23);
            this.queueButton.Margin = new System.Windows.Forms.Padding(2);
            this.queueButton.Name = "queueButton";
            this.queueButton.Size = new System.Drawing.Size(30, 30);
            this.queueButton.TabIndex = 27;
            this.queueButton.UseVisualStyleBackColor = false;
            this.queueButton.Click += new System.EventHandler(this.queueButton_Click);
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.ForeColor = System.Drawing.Color.White;
            this.currentLabel.Location = new System.Drawing.Point(302, 47);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(44, 18);
            this.currentLabel.TabIndex = 28;
            this.currentLabel.Text = "00:00";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(919, 47);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 18);
            this.totalLabel.TabIndex = 29;
            this.totalLabel.Text = "00:00";
            // 
            // musicNameLabel
            // 
            this.musicNameLabel.AutoSize = true;
            this.musicNameLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musicNameLabel.Location = new System.Drawing.Point(12, 19);
            this.musicNameLabel.Name = "musicNameLabel";
            this.musicNameLabel.Size = new System.Drawing.Size(33, 19);
            this.musicNameLabel.TabIndex = 30;
            this.musicNameLabel.Text = "----";
            // 
            // artistNameLabel
            // 
            this.artistNameLabel.AutoSize = true;
            this.artistNameLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.artistNameLabel.Location = new System.Drawing.Point(13, 44);
            this.artistNameLabel.Name = "artistNameLabel";
            this.artistNameLabel.Size = new System.Drawing.Size(19, 14);
            this.artistNameLabel.TabIndex = 31;
            this.artistNameLabel.Text = "----";
            // 
            // volumnButton
            // 
            this.volumnButton.BackColor = System.Drawing.Color.Transparent;
            this.volumnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volumnButton.BackgroundImage")));
            this.volumnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.volumnButton.FlatAppearance.BorderSize = 0;
            this.volumnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.volumnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.volumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumnButton.ForeColor = System.Drawing.Color.Transparent;
            this.volumnButton.Location = new System.Drawing.Point(1048, 24);
            this.volumnButton.Margin = new System.Windows.Forms.Padding(2);
            this.volumnButton.Name = "volumnButton";
            this.volumnButton.Size = new System.Drawing.Size(24, 27);
            this.volumnButton.TabIndex = 33;
            this.volumnButton.UseVisualStyleBackColor = false;
            this.volumnButton.Click += new System.EventHandler(this.volumnButton_Click);
            // 
            // volumnSlider
            // 
            this.volumnSlider.AllowCursorChanges = true;
            this.volumnSlider.AllowHomeEndKeysDetection = false;
            this.volumnSlider.AllowIncrementalClickMoves = true;
            this.volumnSlider.AllowMouseDownEffects = false;
            this.volumnSlider.AllowMouseHoverEffects = false;
            this.volumnSlider.AllowScrollingAnimations = true;
            this.volumnSlider.AllowScrollKeysDetection = true;
            this.volumnSlider.AllowScrollOptionsMenu = true;
            this.volumnSlider.AllowShrinkingOnFocusLost = false;
            this.volumnSlider.BackColor = System.Drawing.Color.Transparent;
            this.volumnSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volumnSlider.BackgroundImage")));
            this.volumnSlider.BindingContainer = null;
            this.volumnSlider.BorderRadius = 2;
            this.volumnSlider.BorderThickness = 1;
            this.volumnSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumnSlider.DrawThickBorder = false;
            this.volumnSlider.DurationBeforeShrink = 2000;
            this.volumnSlider.ElapsedColor = System.Drawing.Color.LightSeaGreen;
            this.volumnSlider.LargeChange = 10;
            this.volumnSlider.Location = new System.Drawing.Point(1080, 19);
            this.volumnSlider.Margin = new System.Windows.Forms.Padding(4);
            this.volumnSlider.Maximum = 100;
            this.volumnSlider.Minimum = 0;
            this.volumnSlider.MinimumSize = new System.Drawing.Size(0, 25);
            this.volumnSlider.MinimumThumbLength = 18;
            this.volumnSlider.Name = "volumnSlider";
            this.volumnSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.volumnSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.volumnSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.volumnSlider.ScrollBarBorderColor = System.Drawing.Color.White;
            this.volumnSlider.ScrollBarColor = System.Drawing.Color.White;
            this.volumnSlider.ShrinkSizeLimit = 3;
            this.volumnSlider.Size = new System.Drawing.Size(123, 37);
            this.volumnSlider.SliderColor = System.Drawing.Color.White;
            this.volumnSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.volumnSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.volumnSlider.SmallChange = 1;
            this.volumnSlider.TabIndex = 32;
            this.volumnSlider.ThumbColor = System.Drawing.Color.White;
            this.volumnSlider.ThumbFillColor = System.Drawing.Color.LightSeaGreen;
            this.volumnSlider.ThumbLength = 18;
            this.volumnSlider.ThumbMargin = 1;
            this.volumnSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.volumnSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.volumnSlider.Value = 50;
            this.volumnSlider.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.volumnSlider_Scroll);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ucPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.volumnButton);
            this.Controls.Add(this.volumnSlider);
            this.Controls.Add(this.artistNameLabel);
            this.Controls.Add(this.musicNameLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.queueButton);
            this.Controls.Add(this.musicSlider);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.loopButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Name = "ucPlayer";
            this.Size = new System.Drawing.Size(1283, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuImageButton playButton;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button loopButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private Bunifu.UI.WinForms.BunifuHSlider musicSlider;
        private System.Windows.Forms.Button queueButton;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label musicNameLabel;
        private System.Windows.Forms.Label artistNameLabel;
        private System.Windows.Forms.Button volumnButton;
        private Bunifu.UI.WinForms.BunifuHSlider volumnSlider;
        private System.Windows.Forms.Timer timer;
    }
}
