using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class TitleDAL
    {
        QuanLyThueDiaDBContext context;
        public TitleDAL()
        {
            context = new QuanLyThueDiaDBContext();
        }
        public List<Title> GetAllTitle()
        {
            return context.Titles.ToList();
        }
        public bool AddTitle(Title title)
        {
            context.Titles.Add(title);
            context.SaveChanges();
            return true;
        }
        public bool UpdateTitle(Title title)
        {
            Title titleUpdate = context.Titles.Find(title.IdTitle);
            context.SaveChanges();
            return true;
        }
        public bool DeleteTitle(int idTitle)
        {
            Title titleDelete = context.Titles.Find(idTitle);
            context.Titles.Remove(titleDelete);
            context.SaveChanges();
            return true;
        }
    }
}
