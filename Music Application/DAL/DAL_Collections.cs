using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;

namespace Music_Application.DAL
{
    public class DAL_Collections
    {
        private static DAL_Collections instance;
        public static DAL_Collections Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Collections();
                }
                return instance;
            }
        }
        private DAL_Collections()
        {

        }
        //Thêm một collection vào database, collection chứa danh sách các bài hát
        public void AddCollection(Collection collection, int[] musicId)
        {
            MusicAppEntities db = new MusicAppEntities();
            foreach (int i in musicId)
            {
                var music = db.Musics.Where(p => p.MusicID == i).FirstOrDefault();
                collection.Musics.Add(music);
            }
            db.Collections.Add(collection);
            db.SaveChanges();
        }
        //Cập nhật collection, collection cập nhật danh sách các bài hát, tên, ảnh, thứ tự
        public void UpdateCollection(int CollectionID, string newName, int[] newMusicID, string imgPath, int order)
        {
            MusicAppEntities db = new MusicAppEntities();
            var collection = db.Collections.Find(CollectionID);
            collection.CollectionName = newName;
            collection.ImageURL = imgPath;
            collection.Musics.Clear();
            foreach (int i in newMusicID)
            {
                var newMusic = db.Musics.Find(i);
                collection.Musics.Add(newMusic);
            }
            collection.DisplayOrder = (short)order;
            db.SaveChanges();
        }
        //Xóa collection khỏi database
        public void RemoveCollection(int CollectionID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var collection = db.Collections.Where(p => p.CollectionID == CollectionID).FirstOrDefault();
            collection.Musics.Clear();
            db.Collections.Remove(collection);
            db.SaveChanges();
        }
        //Lấy collection theo ID
        public Collection GetCollectionByID(int id)
        {
            MusicAppEntities db = new MusicAppEntities();
            var collection = db.Collections.Where(p => p.CollectionID == id).FirstOrDefault();
            return collection;
        }
        //Lấy tất cả collection
        public List<Collection> GetAllCollections()
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Collections.Select(p => p);
            return list.ToList();
        }
        //Lấy collection theo thứ tự hiển thị
        public List<Collection> GetCollectionsByOrder(int order)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Collections.Where(p => p.DisplayOrder == order).ToList();
            return list;
        }
        //Lấy collection cho DataGridView theo tên
        public DataTable GetCollectionsForDGV(string search)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Collections.Where(p => p.CollectionName.Contains(search)).ToList();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("CollectionID", typeof(int)),
                new DataColumn("CollectionName", typeof(string)),
                new DataColumn("DisplayOrder", typeof(int))
            });
            foreach(Collection c in list) 
            {
                dt.Rows.Add(c.CollectionID, c.CollectionName, Convert.ToInt32(c.DisplayOrder));
            }
            return dt;
        }
    }
}
