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

namespace Music_Application.Admin
{
    public partial class NextFormEditMusic : Form
    {
        private Music editMusic;
        public NextFormEditMusic(Music music)
        {
            InitializeComponent();
            editMusic = music;
            loadMusic();
        }
        public void loadMusic()
        {
            nameTextBox.Text = editMusic.MusicName;
            artistTextBox.Text = BLL_Aritsts.Instance.GetArtistByID(editMusic.ArtistID.Value).ArtistName;
            dateTimePicker1.Value = editMusic.ReleaseDate.Value;
            fileLabel.Text = editMusic.MusicURL.Substring(editMusic.MusicURL.LastIndexOf('\\') + 1); // Get file name
            imageLabel.Text = editMusic.ImageURL.Substring(editMusic.ImageURL.LastIndexOf('\\') + 1); // Get file name
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            editMusic.MusicName = nameTextBox.Text;
            editMusic.ArtistID = BLL_Aritsts.Instance.GetArtistByName(artistTextBox.Text).ArtistID;
            editMusic.ReleaseDate = dateTimePicker1.Value;
            editMusic.MusicURL = @"\\DESKTOP-0S75DS2\Music\" + fileLabel.Text;
            editMusic.ImageURL = @"\\DESKTOP-0S75DS2\Image\" + imageLabel.Text;
            BLL_Musics.Instance.EditMusic(editMusic);
            MessageBox.Show("Edit music successfully!");
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 Files|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileLabel.Text = ofd.SafeFileName;
            }
        }

        private void imgButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageLabel.Text = ofd.SafeFileName;
            }
        }
    }
}
