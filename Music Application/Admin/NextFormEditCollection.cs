using Music_Application.BLL;
using Music_Application.DAL;
using Music_Application.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Application.Admin
{
    public partial class NextFormEditCollection : Form
    {
        private int collectionID;
        public NextFormEditCollection(int collectionID, string name, int order)
        {
            InitializeComponent();
            this.collectionID = collectionID;
            nameTextBox.Text = name;
            setCBB();
            comboBox.SelectedIndex = order;
            loadCollection();
        }
        public void setCBB()
        {
            List<CBBItem> list = new List<CBBItem>(new CBBItem[]
            {
                new CBBItem { Value = 0, Text = "Không hiển thị" },
                new CBBItem { Value = 1, Text = "Nghệ sĩ Việt" },
                new CBBItem { Value = 2, Text = "Nghệ sĩ Nước Ngoài" },
                new CBBItem { Value = 3, Text = "Có thể bạn sẽ thích" },
                new CBBItem { Value = 4, Text = "Album phổ biến" },
                new CBBItem { Value = 5, Text = "Tuyển tập nhạc theo tâm trạng" }
            });
            comboBox.Items.AddRange(list.ToArray());
        }
        public void loadCollection()
        {
            DataTable dt = BLL_Musics.Instance.GetMusicsForDGV(collectionID);
            foreach (DataRow dr in dt.Rows)
            {
                DGVList.Rows.Add(dr["MusicID"], dr["MusicName"], dr["ArtistName"]);
            }

            imgLabel.Text = BLL_Collections.Instance.GetCollectionByID(collectionID).ImageURL.Substring(BLL_Collections.Instance.GetCollectionByID(collectionID).ImageURL.LastIndexOf('\\') + 1);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DGVSearch.DataSource = BLL_Musics.Instance.GetMusicsForDGV(searchTextBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGVSearch.SelectedRows)
            {
                DGVList.Rows.Add(Convert.ToInt32(row.Cells["MusicID"].Value), row.Cells["MusicName"].Value.ToString(), 
                    row.Cells["ArtistName"].Value.ToString());
            }
        }
        private void removeBt_Click(object sender, EventArgs e)
        {
            if (DGVList.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVList.SelectedRows)
                    DGVList.Rows.Remove(row);
            }
        }
        private void submitBt_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tuyển tập!");
                return;
            }
            int[] musicIDs = new int[DGVList.Rows.Count];
            for (int i = 0; i < musicIDs.Length; i++)
            {
                musicIDs[i] = Convert.ToInt32(DGVList.Rows[i].Cells[0].Value);
            }
            string imgPath = @"\\DESKTOP-0S75DS2\Image\" + imgLabel.Text;
            BLL_Collections.Instance.UpdateCollection(collectionID, nameTextBox.Text, musicIDs, imgPath, ((CBBItem)comboBox.SelectedItem).Value);
            MessageBox.Show("Cập nhật thành công!");
        }

        private void imgButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLabel.Text = ofd.SafeFileName;
            }
        }
    }
}
