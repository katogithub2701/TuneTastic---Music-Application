using Music_Application.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Music_Application.BLL
{
    public class BLL_Users
    {
        public User currentUser { get; set;}
        private static BLL_Users _Instance;
        public static BLL_Users Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Users();
                return _Instance;
            }
            private set { }
        }
        private BLL_Users() 
        { 

        }

        //Kiểm tra account và password khi đăng nhập
        public bool checkLogIn(string account, string password)
        {
            User user = DAL_Users.Instance.GetUser(account, password);
            if (user != null) 
            {
                currentUser = user;
                return true;
            }
            else
                return false;
        }

        //Thêm User mới
        public void addUser(string name, string account, string password, string email) 
        {
            User newUser = new User();
            newUser.UserName = name;
            newUser.UserLoginName = account;
            newUser.UserPassword = password;
            newUser.Email = email;
            DAL_Users.Instance.addNewUser(newUser);
        }

        //Kiểm tra account và email đã tồn tại chưa khi đăng ký
        public bool checkSignUp(string account, string email)
        {
            return DAL_Users.Instance.Check(account, email);
        }

        //Thêm Playlist mới
        public int addPlaylist(string name)
        {
            Playlist pl = new Playlist();
            pl.PlaylistName = name;
            DAL_Users.Instance.addPlaylistToUser(pl, currentUser.UserID);
            return pl.PlaylistID;
        }

        //Thêm Music vào Playlist
        public void addMusicToPlaylist(int musicId, int playlistId) 
        {
            Playlist pl = DAL_Playlists.Instance.GetPlaylistByID(playlistId);
            foreach (Music music in pl.Musics)
            {
                if (music.MusicID == musicId)
                {
                    return;
                }
            }
            DAL_Users.Instance.addMusicToPlaylist(musicId, playlistId);
        }

        //Lấy password từ email
        public string GetPassword(string email)
        {
            if (DAL_Users.Instance.GetPassword(email) == null)
            {
                return null;
            }
            else
            {
                return DAL_Users.Instance.GetPassword(email);
            }
        }

        //Lấy account từ email
        public string GetAccount(string email)
        {
            if (DAL_Users.Instance.GetAccount(email) == null)
            {
                return null;
            }
            else
            {
                return DAL_Users.Instance.GetAccount(email);
            }
        }
    }
}
