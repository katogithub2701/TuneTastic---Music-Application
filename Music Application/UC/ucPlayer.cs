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

namespace Music_Application.UC
{
    public partial class ucPlayer : UserControl
    {
        public event EventHandler queueButtonClicked;
        DateTime lastUpdate = DateTime.MinValue;
        int previousVolume;
        public ucPlayer()
        {
            InitializeComponent();
            BLL_Player.Instance.SongChanged += nextButton_Click;

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (BLL_Player.Instance.getCurrentMusic() == null) //Nếu không có bài hát nào đang phát thì không làm gì cả
            {
                return;
            }
            if (BLL_Player.Instance.isPlaying)
            {
                BLL_Player.Instance.pauseMusic();
            }
            else
            {
                BLL_Player.Instance.playMusic();
                updatePlayer(); //Cập nhật thông tin bài hát vào player
            }
            UpdatePlayButtonImage(); //Cập nhật hình ảnh cho nút play
        }
        public void updatePlayer()
        {
            timer.Start();
            Music currentMusic = BLL_Player.Instance.getCurrentMusic();
            musicNameLabel.Text = currentMusic.MusicName;
            artistNameLabel.Text = currentMusic.Artist.ArtistName;
            UpdatePlayButtonImage();
        }
        private void UpdatePlayButtonImage()
        {
            if (BLL_Player.Instance.isPlaying)
            {
                playButton.Image = Properties.Resources.wpause;
            }
            else
            {
                playButton.Image = Properties.Resources.wplay;
            }
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_Player.Instance.previousSong();
                updatePlayer();
            }
            catch { }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_Player.Instance.nextSong();
                updatePlayer();
            }
            catch { }
        }
        private void shuffleButton_Click(object sender, EventArgs e)
        {
            if (!BLL_Player.Instance.isShuffle)
            {
                shuffleButton.BackgroundImage = Properties.Resources.shuffle;
                BLL_Player.Instance.Shuffle(true);
            }
            else
            {
                shuffleButton.BackgroundImage = Properties.Resources.wshuffle;
                BLL_Player.Instance.Shuffle(false);
            }
        }
        private void loopButton_Click(object sender, EventArgs e)
        { 
            if (!BLL_Player.Instance.isLoop)
            {
                BLL_Player.Instance.Loop(true);
                loopButton.BackgroundImage = Properties.Resources.loop;
                BLL_Musics.Instance.UpdatePlayCount(BLL_Player.Instance.getCurrentMusic().MusicID);
            }    
            else
            {
                BLL_Player.Instance.Loop(false);
                loopButton.BackgroundImage = Properties.Resources.wrepeat;
            }    
                
        }
        private void queueButton_Click(object sender, EventArgs e)
        {
            queueButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //Nếu đang phát nhạc và nhạc đang được phát thì cập nhật thanh trượt
            if (BLL_Player.Instance.isPlaying && BLL_Player.Instance.player.currentMedia != null 
                && BLL_Player.Instance.player.currentMedia.duration != 0)
            {
                double currentTime = BLL_Player.Instance.player.controls.currentPosition;
                double totalTime = BLL_Player.Instance.player.currentMedia.duration;
                double ratio = currentTime / totalTime;
                DateTime now = DateTime.Now;
                if ((now - lastUpdate).TotalMilliseconds > 1000)
                {
                    musicSlider.Value = (int)(ratio * 100);
                    lastUpdate = now;
                }
                updateCurrentTime(currentTime);
                updateDuration(totalTime);
            }
        }
        private void updateCurrentTime(double currentTime)
        {
            TimeSpan currentTimeSpan = TimeSpan.FromSeconds(currentTime);
            string currentTimeString = currentTimeSpan.ToString(@"mm\:ss");
            currentLabel.Text = currentTimeString;
        }
        private void updateDuration(double dur)
        {
            TimeSpan duration = TimeSpan.FromSeconds(dur);
            string durString = duration.ToString(@"mm\:ss");
            totalLabel.Text = durString;
        }

        private void musicSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            BLL_Player.Instance.Scroll(musicSlider.Value);
        }

        private void volumnSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            if (volumnSlider.Value == 0)
            {
                BLL_Player.Instance.setVolume(0);
                volumnButton.BackgroundImage = Properties.Resources.wmute;
            }
            else
            {
                BLL_Player.Instance.setVolume(volumnSlider.Value);
                volumnButton.BackgroundImage = Properties.Resources.wsound;                
            }
        }

        private void volumnButton_Click(object sender, EventArgs e)
        {
            if (BLL_Player.Instance.player.settings.volume == 0)
            {
                BLL_Player.Instance.setVolume(previousVolume);
                volumnButton.BackgroundImage = Properties.Resources.wsound;
                volumnSlider.Value = previousVolume;
            }
            else
            {
                previousVolume = BLL_Player.Instance.getVolume();
                volumnSlider.Value = 0;
                BLL_Player.Instance.setVolume(0);
                volumnButton.BackgroundImage = Properties.Resources.wmute;
            }
        }

        private void musicSlider_MouseUp(object sender, MouseEventArgs e)
        {
            BLL_Player.Instance.playMusic();
        }

        private void musicSlider_MouseDown(object sender, MouseEventArgs e)
        {
            BLL_Player.Instance.pauseMusic();
        }
    }
}
