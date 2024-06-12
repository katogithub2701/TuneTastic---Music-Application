using Music_Application.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Application.BLL
{
    public class BLL_Musics
    {
        private static BLL_Musics instance;
        public static BLL_Musics Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLL_Musics();
                }
                return instance;
            }
        }
        private BLL_Musics()
        {

        }
        public List<Music> GetAllMusics()
        {
            return DAL.DAL_Musics.Instance.GetAllMusics();
        }
        public List<Music> GetMusicByName(string name)
        {
            return DAL.DAL_Musics.Instance.GetMusicByName(name);
        }
        public void UpdatePlayCount(int musicID)
        {
            DAL.DAL_Musics.Instance.UpdatePlayCount(musicID);
        }
        public List<Music> GetTop5Musics()
        {
            return DAL.DAL_Musics.Instance.getTop(5);
        }
        public void AddMusic(Music music)
        {
            DAL.DAL_Musics.Instance.AddMusic(music);
        }
        public void RemoveMusic(int musicID)
        {
            DAL.DAL_Musics.Instance.RemoveMusic(musicID);
        }
        public void EditMusic(Music music)
        {
            DAL.DAL_Musics.Instance.EditMusic(music);
        }
        public DataTable GetMusicsForDGV(string search)
        {
            return DAL_Musics.Instance.GetMusicsForDGV(search);
        }
        public DataTable GetMusicsForDGV(int id)
        {
            return DAL_Musics.Instance.GetMusicsForDGV(id);
        }

    }
}
