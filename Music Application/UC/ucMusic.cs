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
using WMPLib;

namespace Music_Application
{
    public partial class ucMusic : UserControl
    {
        public Music music { get; set;} = null;
        public ucMusic()
        {
            InitializeComponent();
        }
        public void load()
        {
            label1.Text = music.MusicName;
            label2.Text = music.Artist.ArtistName;
            viewLabel.Text = music.TotalViews.ToString();
            pictureBox1.BackgroundImage = Image.FromFile(music.ImageURL);
        }

        private void queueBt_Click(object sender, EventArgs e)
        {
            BLL_Player.Instance.addMusic(music);
        }

        private void playlistBt_Click(object sender, EventArgs e)
        {
            Point buttonLocation = MousePosition;
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

        private void playBt_Click(object sender, EventArgs e)
        {
            BLL_Player.Instance.playAddedMusic(music);
            MainForm.Instance.setPlayer();
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
