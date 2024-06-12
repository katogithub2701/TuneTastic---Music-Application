using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music_Application.BLL;

namespace Music_Application.DAL
{
    public class DAL_Musics
    {      
        private static DAL_Musics instance;
        public static DAL_Musics Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Musics();
                }
                return instance;
            }
        }
        private DAL_Musics()
        {

        }
        //Lấy tất cả nhạc
        public List<Music> GetAllMusics()
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Musics.Select(p => p);
            return list.ToList();
        }

        //Lấy nhạc của 1 playlist
        public List<Music> GetMusicsFromPlaylist(int PlaylistID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var playlist = db.Playlists.Where(p => p.PlaylistID == PlaylistID).FirstOrDefault();
            return playlist.Musics.ToList();
        }

        //Tìm kiếm nhạc theo tên
        public List<Music> GetMusicByName(string musicName)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Musics.Where(p => p.MusicName.Contains(musicName) || p.Artist.ArtistName.Contains(musicName)).Select(p => p);
            return list.ToList();
        }

        //Cập nhật lượt nghe
        public void UpdatePlayCount(int MusicID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var music = db.Musics.Where(p => p.MusicID == MusicID).FirstOrDefault();
            music.TotalViews += 1;
            db.SaveChanges();
        }

        //Lấy top nhạc
        public List<Music> getTop(int count)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Musics.OrderByDescending(p => p.TotalViews).Take(count);
            return list.ToList();
        }
        //Thêm nhạc
        public void AddMusic(Music music)
        {
            MusicAppEntities db = new MusicAppEntities();
            db.Musics.Add(music);
            db.SaveChanges();
        }
        //Xóa nhạc
        public void RemoveMusic(int MusicID)
        {
            MusicAppEntities db = new MusicAppEntities();
            Music music = db.Musics.Where(p => p.MusicID == MusicID).FirstOrDefault();
            db.Musics.Remove(music);
            db.SaveChanges();
        }
        //Sửa nhạc
        public void EditMusic(Music editmusic)
        {
            MusicAppEntities db = new MusicAppEntities();
            var music = db.Musics.Find(editmusic.MusicID);
            if (music != null)
            {
                music.MusicName = editmusic.MusicName;
                music.ArtistID = editmusic.ArtistID;
                music.ReleaseDate = editmusic.ReleaseDate;
                music.MusicURL = editmusic.MusicURL;
                music.ImageURL = editmusic.ImageURL;
                db.SaveChanges();
            }
        }
        //Lấy danh sách nhạc cho DataGridView theo tên
        public DataTable GetMusicsForDGV(string search)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Musics.Where(p => p.MusicName.Contains(search) || p.Artist.ArtistName.Contains(search)).ToList();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MusicID", typeof(int)),
                new DataColumn("MusicName", typeof(string)),
                new DataColumn("ArtistName", typeof(string))
            });
            foreach (Music c in list)
            {
                dt.Rows.Add(c.MusicID, c.MusicName, c.Artist.ArtistName);
            }
            return dt;
        }
        //Lấy danh sách nhạc cho DataGridView theo ID
        public DataTable GetMusicsForDGV(int collectionID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Musics.Where(p => p.Collections.Any(c => c.CollectionID == collectionID)).ToList();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MusicID", typeof(int)),
                new DataColumn("MusicName", typeof(string)),
                new DataColumn("ArtistName", typeof(string))
            });
            foreach (Music c in list)
            {
                dt.Rows.Add(c.MusicID, c.MusicName, c.Artist.ArtistName);
            }
            return dt;
        }
    }
}
