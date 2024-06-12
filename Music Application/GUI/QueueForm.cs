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
    public partial class QueueForm : Form
    {
        public QueueForm()
        {
            InitializeComponent();
            loadMusic();
        }
        public void loadMusic()
        {
            foreach (Music music in BLL_Player.Instance.musicQueue)
            {
                ucMusicInQueue bar = new ucMusicInQueue();
                bar.music = music;
                bar.load();
                bar.RemoveButtonClick += RemoveMusicFromQueue;
                queuePanel.Controls.Add(bar);
            }
        }
        private void RemoveMusicFromQueue(object sender, EventArgs e)
        {
            ucMusicInQueue removedBar = sender as ucMusicInQueue;
            queuePanel.Controls.Remove(removedBar);
        }
    }
}
