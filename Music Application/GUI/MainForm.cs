using Music_Application.Admin;
using Music_Application.BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Music_Application
{
    public partial class MainForm : Form
    {
        private static MainForm _Instance = new MainForm();
        public static MainForm Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new MainForm();
                }
                return _Instance;
            }
        }
        private Form currentForm;
        private MainForm()
        {
            InitializeComponent();
            openForm(new HomeForm());
            LoadUser();
            Player.queueButtonClicked += queueButton_Clicked;
        }
        private void LoadUser()
        {
            int userId = BLL_Users.Instance.currentUser.UserID; // 0 is admin
            if (userId == 0)
                adminLabel.Visible = true;
            usernameLabel.Text = BLL_Users.Instance.currentUser.UserName;
            List<Playlist> playlists = BLL_Playlists.Instance.GetPlaylistsByUser(userId);
            foreach (Playlist playlist in playlists)
            {
                ucPlaylist ucPlaylist = new ucPlaylist();
                ucPlaylist.Click += UcPlaylist_PlaylistClick;
                ucPlaylist.removeBtClick += UcPlaylist_RemoveBtClick;
                ucPlaylist.playlistID = playlist.PlaylistID;
                ucPlaylist.load();
                playlistPanel.Controls.Add(ucPlaylist);               
            }
        }
        public void openForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Dispose();
            }
            currentForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.homePanel.Controls.Add(form);
            this.homePanel.Tag = form;
            form.BringToFront();
            form.Show();
            currentPanelName.Text = form.Text;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            openForm(new HomeForm());
        }

        private void addPlaylistButton_Click(object sender, EventArgs e)
        {
            addPlaylistForm addPlaylistForm = new addPlaylistForm();
            addPlaylistForm.ShowDialog();
            if (addPlaylistForm.isCancel) return;
            int playlistId = BLL_Users.Instance.addPlaylist(addPlaylistForm.textBox);
            ucPlaylist ucPlaylist = new ucPlaylist();
            ucPlaylist.playlistID = playlistId;
            ucPlaylist.load();
            ucPlaylist.Click += UcPlaylist_PlaylistClick;
            ucPlaylist.removeBtClick += UcPlaylist_RemoveBtClick;
            playlistPanel.Controls.Add(ucPlaylist);
        }

        private void UcPlaylist_PlaylistClick(object sender, EventArgs e)
        {
            ucPlaylist playlistControl = sender as ucPlaylist;
            if (playlistControl != null)
            {
                openForm(new PlaylistForm(playlistControl.playlistID));
                currentPanelName.Text = BLL_Playlists.Instance.GetPlaylistByID(playlistControl.playlistID).PlaylistName;
            }
        }
        private void UcPlaylist_RemoveBtClick(object sender, EventArgs e)
        {
            ucPlaylist playlistControl = sender as ucPlaylist;
            playlistPanel.Controls.Remove(playlistControl);
        }
        private void queueButton_Clicked(object sender, EventArgs e)
        {
            openForm(new QueueForm());
        }

        private void signOutLabel_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm form = currentForm as SearchForm;
            if (form == null)
            {                      
                openForm(new SearchForm());
                form = currentForm as SearchForm;               
            }
            form.loadResult(searchtextBox.Text);
        }

        private void searchtextBox_Click(object sender, EventArgs e)
        {
            SearchForm form = currentForm as SearchForm;
            if (form == null)
            {
                openForm(new SearchForm());
            }
        }
        public void setPlayer()
        {
            Player.updatePlayer();
        }

        private void adminLabel_Click(object sender, EventArgs e)
        {
            AdminForm.Instance.ShowDialog();
        }

        private void searchtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }
    }
}
