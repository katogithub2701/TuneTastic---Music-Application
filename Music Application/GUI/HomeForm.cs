using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music_Application.BLL;
using Music_Application.DAL;
using Music_Application.GUI;

namespace Music_Application
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            loadTopPanel();
            loadCollectionPanel(5);
        }
        private void loadTopPanel()
        {
            List<Music> listMusic = BLL_Musics.Instance.GetTop5Musics();
            foreach (Music music in listMusic)
            {
                ucMusic bar = new ucMusic();
                bar.music = music;
                bar.load();
                topPanel.Controls.Add(bar);
            }
        }
        private void loadCollectionPanel(int total)
        {
            for (int i = 1; i <= total; i++)
            {
                List<Collection> listCollection = BLL_Collections.Instance.GetCollectionsByOrder(i);
                foreach (Collection cl in listCollection)
                {
                    ucCollection bar = new ucCollection();
                    bar.collectionId = cl.CollectionID;
                    bar.pictureBoxClick += pictureBoxClick;
                    bar.load();
                    switch (i)
                    {
                        case 1: firstPanel.Controls.Add(bar); break;
                        case 2: secondPanel.Controls.Add(bar); break;
                        case 3: thirdPanel.Controls.Add(bar); break;
                        case 4: fourthPanel.Controls.Add(bar); break;
                        case 5: fifthPanel.Controls.Add(bar); break;
                    }
                }
            }
        }
        private void pictureBoxClick(object sender, EventArgs e)
        {
            ucCollection box = sender as ucCollection;
            MainForm.Instance.openForm(new CollectionForm(box.collectionId));
        }
    }
}
