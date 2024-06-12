using Music_Application.BLL;
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
    public partial class ucCollection : UserControl
    {
        public int collectionId { get; set; }
        public event EventHandler pictureBoxClick;
        public ucCollection()
        {
            InitializeComponent();
        }
        public void load()
        {
            Collection collection = BLL_Collections.Instance.GetCollectionByID(collectionId);
            titleLabel.Text = collection.CollectionName;            
            playlistPic.BackgroundImage = Image.FromFile(collection.ImageURL);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBoxClick?.Invoke(this, EventArgs.Empty);
        }

        private void playBt_Click(object sender, EventArgs e)
        {
            Collection collection = BLL_Collections.Instance.GetCollectionByID(collectionId);
            BLL_Player.Instance.setMusicQueue(collection.Musics.ToList());
            MainForm.Instance.setPlayer();
        }

        private void playBt_MouseEnter(object sender, EventArgs e)
        {
            playBt.BackgroundImage = Properties.Resources.wyellowplay;
        }

        private void playBt_MouseLeave(object sender, EventArgs e)
        {
            playBt.BackgroundImage = Properties.Resources.wplay;
        }
    }
}
