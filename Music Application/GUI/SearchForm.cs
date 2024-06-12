using Music_Application.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Application
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        public SearchForm(string s)
        {
            InitializeComponent();
            loadResult(s);
        }
        public void loadResult(string s)
        {
            if (s == "") return;
            resultPanel.Controls.Clear();
            List<Music> resultList = BLL_Musics.Instance.GetMusicByName(s);
            if (resultList.Count != 0)
            {
                foreach (Music music in resultList)
                {
                    ucMusic bar = new ucMusic();
                    bar.music = music;
                    bar.load();
                    resultPanel.Controls.Add(bar);
                }
            }
            else
            {
                resultPanel.Controls.Add(new Label() 
                { 
                    Text = "Không tìm thấy kết quả!",
                    ForeColor = SystemColors.ControlLightLight,
                    AutoSize = true,
                    Font = new Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
                });
            }
            resultPanel.Refresh();
        }
    }
}
