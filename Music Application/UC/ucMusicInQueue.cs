using Music_Application.BLL;
using System;
using System.Collections;
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
    public partial class ucMusicInQueue : UserControl
    {
        public event EventHandler RemoveButtonClick;
        public Music music { get; set; }
        public ucMusicInQueue()
        {
            InitializeComponent();
        }
        public void load()
        {
            label1.Text = music.MusicName;
            label2.Text = music.Artist.ArtistName;
            pictureBox1.BackgroundImage = Image.FromFile(music.ImageURL);
        }
        private void playlistBt_Click(object sender, EventArgs e)
        {
            Point buttonLocation = Control.MousePosition;
            addToPlaylistForm form = new addToPlaylistForm();
            form.Location = buttonLocation;
            form.ShowDialog();
            if (form.isCancel)
            {
                return;
            }
            int playlistId = form.selectedPlaylistID;
            BLL_Users.Instance.addMusicToPlaylist(music.MusicID, playlistId);
        }


        private void removeBt_Click(object sender, EventArgs e)
        {
            BLL_Player.Instance.removeMusic(music);
            RemoveButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void playBt_Click(object sender, EventArgs e)
        {
            BLL_Player.Instance.playMusicInQueue(music);
        }

        private void playBt_MouseEnter(object sender, EventArgs e)
        {
            playBt.Image = Properties.Resources.wyellowplay;
        }

        private void playBt_MouseLeave(object sender, EventArgs e)
        {
            playBt.Image = Properties.Resources.wplay;
        }
    }
}
