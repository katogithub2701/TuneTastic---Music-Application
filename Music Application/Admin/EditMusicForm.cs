using Music_Application.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Application.Admin
{
    public partial class EditMusicForm : Form
    {
        private Music editMusic;
        public EditMusicForm()
        {
            InitializeComponent();
            AdminForm.Instance.openForm(new AddMusicForm(), this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns.Clear();
            }    
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MusicID", HeaderText = "MusicID" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MusicName", HeaderText = "Title" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ArtistID", HeaderText = "Artist" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MusicURL", HeaderText = "URL" });
            dataGridView1.DataSource = BLL_Musics.Instance.GetMusicByName(searchTextBox.Text);
        }
        public bool EditDatabase()
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn một bài hát!");
                return false;
            }
            else
            {
                Music music = BLL_Musics.Instance.GetMusicByName(dataGridView1.SelectedRows[0].Cells[1].Value.ToString())[0];
                editMusic = music;
                return true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (EditDatabase())
                AdminForm.Instance.openForm(new NextFormEditMusic(editMusic), this);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one music to delete!");
                return;
            }
            else
            {
                List<int> musicIDs = new List<int>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int musicID = (int)row.Cells[0].Value;
                    musicIDs.Add(musicID);
                }
                foreach (int musicID in musicIDs)
                {
                    BLL_Musics.Instance.RemoveMusic(musicID);
                }
                MessageBox.Show("Delete selected musics successfully!");
                dataGridView1.DataSource = BLL_Musics.Instance.GetMusicByName(searchTextBox.Text);
            }
        }
    }
}
            
