namespace Music_Application
{
    partial class ucPlaylist
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
            this.label1 = new System.Windows.Forms.Label();
            this.removeBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phát của tôi #1";
            // 
            // removeBt
            // 
            this.removeBt.BackgroundImage = global::Music_Application.Properties.Resources.wminus;
            this.removeBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeBt.FlatAppearance.BorderSize = 0;
            this.removeBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.removeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBt.Location = new System.Drawing.Point(170, 7);
            this.removeBt.Name = "removeBt";
            this.removeBt.Size = new System.Drawing.Size(22, 22);
            this.removeBt.TabIndex = 1;
            this.removeBt.UseVisualStyleBackColor = true;
            this.removeBt.Click += new System.EventHandler(this.removeBt_Click);
            // 
            // ucPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.removeBt);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucPlaylist";
            this.Size = new System.Drawing.Size(200, 34);
            this.MouseEnter += new System.EventHandler(this.ucPlaylist_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucPlaylist_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeBt;
    }
}
