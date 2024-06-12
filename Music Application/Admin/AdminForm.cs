using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Application.Admin
{
    public partial class AdminForm : Form
    {
        private static AdminForm instance;
        public static AdminForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AdminForm();
                }
                return instance;
            }
        }
        private Form currentForm;
        public AdminForm()
        {
            InitializeComponent();
            openForm(new AddMusicForm(), this);
        }
        public void openForm(Form form, object sender)
        {
            if (currentForm != null)
            {
                currentForm.Dispose();
            }
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void addLabel_Click(object sender, EventArgs e)
        {
            openForm(new AddMusicForm(), this);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editLabel_Click(object sender, EventArgs e)
        {
            openForm(new EditMusicForm(), this);
        }
        private void addColLabel_Click(object sender, EventArgs e)
        {
            openForm(new AddCollectionForm(), this);
        }

        private void editCollabel_Click(object sender, EventArgs e)
        {
            openForm(new EditCollectionForm(), this);
        }
    }
}
