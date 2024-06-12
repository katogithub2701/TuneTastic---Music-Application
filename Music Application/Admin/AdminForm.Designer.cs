namespace Music_Application.Admin
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addColLabel = new System.Windows.Forms.Label();
            this.editCollabel = new System.Windows.Forms.Label();
            this.bunifuShapes1 = new Bunifu.UI.WinForms.BunifuShapes();
            this.editLabel = new System.Windows.Forms.Label();
            this.addLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.closeButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.addColLabel);
            this.panel1.Controls.Add(this.editCollabel);
            this.panel1.Controls.Add(this.bunifuShapes1);
            this.panel1.Controls.Add(this.editLabel);
            this.panel1.Controls.Add(this.addLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 531);
            this.panel1.TabIndex = 8;
            // 
            // addColLabel
            // 
            this.addColLabel.AutoSize = true;
            this.addColLabel.BackColor = System.Drawing.Color.Transparent;
            this.addColLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addColLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addColLabel.ForeColor = System.Drawing.Color.White;
            this.addColLabel.Location = new System.Drawing.Point(19, 229);
            this.addColLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addColLabel.Name = "addColLabel";
            this.addColLabel.Size = new System.Drawing.Size(120, 19);
            this.addColLabel.TabIndex = 14;
            this.addColLabel.Text = "Thêm tuyển tập";
            this.addColLabel.Click += new System.EventHandler(this.addColLabel_Click);
            // 
            // editCollabel
            // 
            this.editCollabel.AutoSize = true;
            this.editCollabel.BackColor = System.Drawing.Color.Transparent;
            this.editCollabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editCollabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCollabel.ForeColor = System.Drawing.Color.White;
            this.editCollabel.Location = new System.Drawing.Point(19, 278);
            this.editCollabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editCollabel.Name = "editCollabel";
            this.editCollabel.Size = new System.Drawing.Size(151, 19);
            this.editCollabel.TabIndex = 13;
            this.editCollabel.Text = "Chỉnh sửa tuyển tập";
            this.editCollabel.Click += new System.EventHandler(this.editCollabel_Click);
            // 
            // bunifuShapes1
            // 
            this.bunifuShapes1.Angle = 0F;
            this.bunifuShapes1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuShapes1.BorderThickness = 2;
            this.bunifuShapes1.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.FillShape = true;
            this.bunifuShapes1.Location = new System.Drawing.Point(0, 59);
            this.bunifuShapes1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuShapes1.Name = "bunifuShapes1";
            this.bunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.bunifuShapes1.Sides = 5;
            this.bunifuShapes1.Size = new System.Drawing.Size(188, 61);
            this.bunifuShapes1.TabIndex = 0;
            this.bunifuShapes1.Text = "bunifuShapes1";
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.BackColor = System.Drawing.Color.Transparent;
            this.editLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel.ForeColor = System.Drawing.Color.White;
            this.editLabel.Location = new System.Drawing.Point(19, 180);
            this.editLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(120, 19);
            this.editLabel.TabIndex = 11;
            this.editLabel.Text = "Chỉnh sửa nhạc";
            this.editLabel.Click += new System.EventHandler(this.editLabel_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.BackColor = System.Drawing.Color.Transparent;
            this.addLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLabel.ForeColor = System.Drawing.Color.White;
            this.addLabel.Location = new System.Drawing.Point(19, 134);
            this.addLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(89, 19);
            this.addLabel.TabIndex = 9;
            this.addLabel.Text = "Thêm nhạc";
            this.addLabel.Click += new System.EventHandler(this.addLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.titleLabel.Location = new System.Drawing.Point(51, 30);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(79, 25);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "ADMIN";
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(187, 29);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(733, 499);
            this.mainPanel.TabIndex = 9;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // closeButton
            // 
            this.closeButton.ActiveImage = null;
            this.closeButton.AllowAnimations = true;
            this.closeButton.AllowBuffering = false;
            this.closeButton.AllowToggling = false;
            this.closeButton.AllowZooming = true;
            this.closeButton.AllowZoomingOnFocus = false;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("closeButton.ErrorImage")));
            this.closeButton.FadeWhenInactive = false;
            this.closeButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.ImageLocation = null;
            this.closeButton.ImageMargin = 0;
            this.closeButton.ImageSize = new System.Drawing.Size(12, 13);
            this.closeButton.ImageZoomSize = new System.Drawing.Size(13, 14);
            this.closeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("closeButton.InitialImage")));
            this.closeButton.Location = new System.Drawing.Point(898, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Rotation = 0;
            this.closeButton.ShowActiveImage = true;
            this.closeButton.ShowCursorChanges = true;
            this.closeButton.ShowImageBorders = true;
            this.closeButton.ShowSizeMarkers = false;
            this.closeButton.Size = new System.Drawing.Size(13, 14);
            this.closeButton.TabIndex = 7;
            this.closeButton.ToolTipText = "";
            this.closeButton.WaitOnLoad = false;
            this.closeButton.Zoom = 0;
            this.closeButton.ZoomSpeed = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(920, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.Text = "adminForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.Panel mainPanel;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Label addColLabel;
        private System.Windows.Forms.Label editCollabel;
    }
}