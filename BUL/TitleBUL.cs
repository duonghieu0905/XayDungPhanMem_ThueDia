using DAL;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace BUL
{
    public class TitleBUL
    {
        private TitleDAL db;
        public TitleBUL()
        {
            db = new TitleDAL();
        }
        public List<Title> GetTitles()
        {
            return db.GetAllTitle();
        }
        public bool AddTitle(Title title)
        {
            return db.AddTitle(title);
        }
        public bool UpdateTitle(Title title)
        {
            return db.UpdateTitle(title);
        }
        public bool DeleteTitle(int idTitle)
        {
            return db.DeleteTitle(idTitle);
        }
        public int TotalDiskOfTitle(int idTitle)
        {
            DiskDAL dbDisk = new DiskDAL();
            return dbDisk.GetAllDisk().Where(x => x.IdTitle == idTitle).Count();
        }
        public int GetLastTitle()
        {
            return db.GetAllTitle().Last().IdTitle;
        }
    }
}
