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
    public partial class EditCollectionForm : Form
    {
        private int collectionID;
        public EditCollectionForm()
        {
            InitializeComponent();
        }
        private void nextBt_Click(object sender, EventArgs e)
        {
            if (DGVSearch.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn một tuyển tập!");
                return;
            }
            collectionID = Convert.ToInt32(DGVSearch.SelectedRows[0].Cells["CollectionID"].Value);
            string nameCollection = DGVSearch.SelectedRows[0].Cells["CollectionName"].Value.ToString();
            int order = Convert.ToInt32(DGVSearch.SelectedRows[0].Cells["DisplayOrder"].Value);
            AdminForm.Instance.openForm(new NextFormEditCollection(collectionID, nameCollection, order), this);
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DGVSearch.DataSource = BLL_Collections.Instance.GetCollectionsForDGV(searchTextBox.Text);
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (DGVSearch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one collection to delete!");
                return;
            }
            else
            {
                foreach (DataGridViewRow row in DGVSearch.SelectedRows)
                {
                    BLL_Collections.Instance.RemoveCollection(Convert.ToInt32(row.Cells["CollectionID"].Value));
                }
                MessageBox.Show("Xóa thành công");
            }
            DGVSearch.DataSource = BLL_Collections.Instance.GetCollectionsForDGV(searchTextBox.Text);
        }
    }
}
