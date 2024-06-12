using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Application
{
    public partial class addPlaylistForm : Form
    {
        public bool isCancel { get; set; } = false;
        public string textBox { get; set; } = "";
        public addPlaylistForm()
        {
            InitializeComponent();
            this.Scale(new SizeF(1.3f, 1.3f));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            isCancel = true;
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            textBox = textBox1.Text;
            this.Close();
        }
    }
}
