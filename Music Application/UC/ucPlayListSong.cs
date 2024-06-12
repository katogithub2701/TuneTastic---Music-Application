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
    public partial class ucPlayListSong : UserControl
    {
        public static ucPlayListSong currentPlayingControl { get; set; } = null;
        public event EventHandler PlayButtonClick;
        public event EventHandler RemoveButtonClick;
        public Playlist musics { get; set; }
        public Music music { get; set; }
        public ucPlayListSong()
        {
            InitializeComponent();
        }
        public void load()
        {
            label1.Text = music.MusicName;
            label2.Text = music.Artist.ArtistName;
            pictureBox1.BackgroundImage = Image.FromFile(music.ImageURL);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BLL_Playlists.Instance.RemoveMusicFromPlaylist(musics.PlaylistID, music.MusicID);
            RemoveButtonClick?.Invoke(this, EventArgs.Empty);
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
