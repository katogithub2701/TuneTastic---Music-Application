using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WMPLib;
using System.Windows.Forms;
using System.Timers;
using Music_Application.BLL;

namespace Music_Application
{
    internal class BLL_Player
    {
        public event EventHandler SongChanged;
        public int currentSongIndex { get; set; } = 0; //Vị trí bài hát đang phát
        //public int originalSongIndex { get; set; } = 0;
        public List<Music> musicQueue { get; set; } //Danh sách nhạc đang phát
        public List<Music> originalQueue { get; set; } //Danh sách nhạc gốc trước khi shuffle
        public WindowsMediaPlayer player { get; set; } = new WindowsMediaPlayer(); //Đối tượng player của Windows Media Player
        public bool isPlaying { get; set; } = false; //Trạng thái phát nhạc
        public bool isLoop { get; set; } = false; //Trạng thái lặp nhạc
        public bool isShuffle { get; set; } = false; //Trạng thái shuffle nhạc

        public static BLL_Player _Instance;

        public static BLL_Player Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Player();
                return _Instance;
            }
            private set { }
        }
        private BLL_Player()
        {
            musicQueue = new List<Music>();
            player.settings.volume = 50;
            player.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(MediaPlayer_PlayStateChange);
        }

        //Thêm bài hát vào danh sách phát
        public void addMusic(Music music)
        {
            if (checkExistMusic(music.MusicID) == false)
            { 
                musicQueue.Add(music);
            }
        }

        //Xóa bài hát khỏi danh sách phát
        public void removeMusic(Music music)
        {
            musicQueue.Remove(music);
        }

        //Phát nhạc
        public void playMusic()
        {
            isPlaying = true;
            if (player.playState == WMPPlayState.wmppsPaused) // Nếu nhạc đang được pause thì tiếp tục phát
            {
                player.controls.play();
            }
            else
            {
                player.URL = musicQueue[currentSongIndex].MusicURL;
                player.controls.play();
                BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
            }
        }

        //Dừng nhạc
        public void pauseMusic()
        {
            isPlaying = false;
            player.controls.pause();
        }

       //Xử lý sự kiện khi nhạc kết thúc
        private async void MediaPlayer_PlayStateChange(int NewState)
        {
            // Nếu nhạc kết thúc và không phải lặp thì tự động chuyển bài
            if ((WMPPlayState)NewState == WMPPlayState.wmppsMediaEnded && !isLoop)
            {
                await Task.Delay(2000);
                if (currentSongIndex >= musicQueue.Count)
                {
                    currentSongIndex = 0;
                }
                playMusic();
                SongChanged?.Invoke(this, EventArgs.Empty);
            }
        }


        //Chuyển bài tiếp theo
        public void nextSong()
        {
            isPlaying = true;
            try
            {
                if (currentSongIndex < musicQueue.Count - 1)
                {
                    currentSongIndex++;
                }
                else
                {
                    currentSongIndex = 0;
                }
                player.URL = musicQueue[currentSongIndex].MusicURL;
                player.controls.play();
                BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
            }
            catch {  }
        }

        //Chuyển bài trước đó
        public void previousSong()
        {
            isPlaying = true;
            try
            {
                if (currentSongIndex > 0)
                {
                    currentSongIndex--;
                }
                else
                {
                    currentSongIndex = musicQueue.Count - 1;
                }
                player.URL = musicQueue[currentSongIndex].MusicURL;
                player.controls.play();
                BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
            }
            catch { }
        }

        //Shuffle danh sách nhạc
        public void Shuffle(bool b)
        {
            isShuffle = b;
            if (isShuffle)
            {
                originalQueue = new List<Music>(musicQueue); //Lưu lại danh sách nhạc gốc trước khi shuffle
                Random random = new Random();
                int n = musicQueue.Count; 
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1); //Chọn một vị trí ngẫu nhiên trong danh sách nhạc
                    //Đổi chỗ 2 bài hát
                    Music value = musicQueue[k];
                    musicQueue[k] = musicQueue[n];
                    musicQueue[n] = value;
                }
            }
            else
            {
                musicQueue = new List<Music>(originalQueue); //Trả lại danh sách nhạc gốc
            }
        }
        public void Loop(bool b)
        {
            isLoop = b;
            player.settings.setMode("loop", b); //Đặt trạng thát loop  
        }

        //Đặt âm lượng
        public void setVolume(int value)
        {
            player.settings.volume = value;
        }

        //Lấy âm lượng
        public int getVolume()
        {
            return player.settings.volume;
        }

        //Tua nhạc
        public void Scroll(int value)
        {
            if (isPlaying)
            {
                double newPotition = player.currentMedia.duration * value / 100;
                if (Math.Abs(player.controls.currentPosition - newPotition) > 0.05)
                {
                    player.controls.currentPosition = newPotition;
                }
            }
        }

        //Đặt danh sách nhạc mới
        public void setMusicQueue(List<Music> queue)
        {
            musicQueue = queue;
            currentSongIndex = 0;
            isPlaying = true;
            if (isShuffle)
                Shuffle(true);
            player.URL = musicQueue[currentSongIndex].MusicURL;
            player.controls.play();
            BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
        }

        //Lấy bài hát hiện tại
        public Music getCurrentMusic()
        {
            try
            {
                return musicQueue[currentSongIndex]; 
            }
            catch { return null; }
        }

        //Phát nhạc từ danh sách nhạc
        public void playMusicInQueue(Music music)
        {
            isPlaying = true;
            int index = orderOfMusicInQueue(music.MusicID);
            currentSongIndex = index;
            player.URL = musicQueue[currentSongIndex].MusicURL;
            player.controls.play();
            BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
            MainForm.Instance.setPlayer();
        }

        //Phát nhạc mới được thêm vào
        public void playAddedMusic(Music music)
        {
            isPlaying = true;
            if (checkExistMusic(music.MusicID) == true)
                playMusicInQueue(music);
            else
            {
                musicQueue.Add(music);
                currentSongIndex = musicQueue.Count - 1;
                player.URL = musicQueue[currentSongIndex].MusicURL;
                player.controls.play();
                BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
            }
        }

        //Kiểm tra bài hát đã tồn tại trong danh sách nhạc chưa
        public bool checkExistMusic(int id)
        {
            foreach(Music music in musicQueue) 
            {
                if (music.MusicID == id)
                {
                    return true;
                }
            }
            return false;
        }

        //Lấy vị trí của bài hát trong danh sách nhạc
        public int orderOfMusicInQueue(int id)
        {
            for (int i = 0; i < musicQueue.Count; i++)
            {
                if (musicQueue[i].MusicID == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}