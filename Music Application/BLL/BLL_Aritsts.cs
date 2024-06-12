using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Application.BLL
{
    internal class BLL_Aritsts
    {
        private static BLL_Aritsts instance;
        public static BLL_Aritsts Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLL_Aritsts();
                }
                return instance;
            }
        }
        private BLL_Aritsts()
        {

        }
        public void AddArtist(Artist artist)
        {
            DAL.DAL_Artists.Instance.AddArtist(artist);
        }
        public List<Artist> GetAllArtists()
        {
            return DAL.DAL_Artists.Instance.GetAllArtists();
        }

        public Artist GetArtistByName(string name)
        {
            return DAL.DAL_Artists.Instance.GetArtistByName(name);
        }
        public Artist GetArtistByID(int id)
        {
            return DAL.DAL_Artists.Instance.GetArtistByID(id);
        }
    }
}
