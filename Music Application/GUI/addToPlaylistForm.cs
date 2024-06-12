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
    public partial class addToPlaylistForm : Form
    {
        public bool isCancel { get; set; } = false;
        public int selectedPlaylistID { get; set; }
        public addToPlaylistForm()
        {
            InitializeComponent();
            setCBB();
        }
        public void setCBB()
        {
            List<DTO.CBBItem> list = new List<DTO.CBBItem>();
            //Lấy danh sách playlist của user hiện tại
            foreach (Playlist playlist in BLL_Playlists.Instance.GetPlaylistsByUser(BLL_Users.Instance.currentUser.UserID))
            {
                list.Add(new DTO.CBBItem { Value = playlist.PlaylistID, Text = playlist.PlaylistName});
            }
            comboBox1.Items.AddRange(list.ToArray());
        }
        private void confirmBt_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                selectedPlaylistID = ((DTO.CBBItem)comboBox1.SelectedItem).Value;
            }
            this.Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            isCancel = true;
            this.Close();
        }
    }
}
