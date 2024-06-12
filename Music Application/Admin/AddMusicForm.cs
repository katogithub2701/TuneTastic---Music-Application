using Music_Application.BLL;
using System;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace Music_Application.Admin
{
    public partial class AddMusicForm : Form
    {
        private string attachedFileMusicName;
        private string attachedFileImageName;

        public AddMusicForm()
        {
            InitializeComponent();
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 Files|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                attachedFileMusicName = ofd.SafeFileName;
                fileLabel.Text = attachedFileMusicName;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (attachedFileMusicName == null || attachedFileImageName == null)
            {
                MessageBox.Show("Vui lòng chọn file nhạc và ảnh!");
                return;
            }
            UpdateDatabase();
            MessageBox.Show("Thêm bài hát thành công!");
        }
        public void UpdateDatabase()
        {
            if (BLL_Aritsts.Instance.GetArtistByName(artistTextBox.Text) == null)
            {
                Artist artist = new Artist()
                {
                    ArtistName = artistTextBox.Text
                };
                BLL_Aritsts.Instance.AddArtist(artist);
            }
            BLL_Musics.Instance.AddMusic(new Music()
            {
                MusicName = nameTextBox.Text,
                ArtistID = BLL_Aritsts.Instance.GetArtistByName(artistTextBox.Text).ArtistID,
                ReleaseDate = dateTimePicker1.Value,
                TotalViews = 0,
                MusicURL = @"\\DESKTOP-0S75DS2\Music\" + attachedFileMusicName,
                ImageURL = @"\\DESKTOP-0S75DS2\Image\" + attachedFileImageName
            });
        }

        private void imgBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                attachedFileImageName = ofd.SafeFileName;
                label6.Text = attachedFileImageName;
            }
        }
    }
}
