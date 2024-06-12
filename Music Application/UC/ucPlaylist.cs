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
    public partial class ucPlaylist : UserControl
    {
        public int playlistID { get; set; }
        public event EventHandler removeBtClick;
        public event EventHandler btClick;
        public ucPlaylist()
        {
            InitializeComponent();
        }
        public void load()
        {
            Playlist playlist = BLL_Playlists.Instance.GetPlaylistByID(playlistID);
            label1.Text = playlist.PlaylistName;
        }

        private void ucPlaylist_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.DimGray;
        }

        private void ucPlaylist_MouseLeave(object sender, EventArgs e)
        {        
            if (GetChildAtPoint(PointToClient(Cursor.Position)) == null)
            {
                BackColor = Color.Transparent;
            }
        }

        private void removeBt_Click(object sender, EventArgs e)
        {
            BLL_Playlists.Instance.RemovePlaylist(playlistID);
            removeBtClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
