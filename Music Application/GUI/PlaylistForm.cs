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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Music_Application
{
    public partial class PlaylistForm : Form
    {
        public int playlistID {  get; set; }
        public PlaylistForm(int ID)
        {
            InitializeComponent();
            load(ID);
        }
        public void load(int ID)
        {
            Playlist playlist = BLL_Playlists.Instance.GetPlaylistByID(ID);
            playlistID = playlist.PlaylistID;
            foreach (Music music in playlist.Musics)
            {
                ucPlayListSong bar = new ucPlayListSong();
                bar.music = music;
                bar.musics = playlist;
                bar.load();
                bar.RemoveButtonClick += RemoveMusicFromPlaylist;
                listPanel.Controls.Add(bar);
            }
            playlistName.Text = playlist.PlaylistName;
        }
        private void RemoveMusicFromPlaylist(object sender, EventArgs e)
        {
            ucPlayListSong removedBar = sender as ucPlayListSong;
            listPanel.Controls.Remove(removedBar);
        }
        private void playBt_Click(object sender, EventArgs e)
        {
            Playlist playlist = BLL_Playlists.Instance.GetPlaylistByID(playlistID);
            BLL_Player.Instance.setMusicQueue(playlist.Musics.ToList());
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
