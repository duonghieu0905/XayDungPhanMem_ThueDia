using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BUL
{
    public class ListRentedBUL
    {
        private ListRentedDAL db;
        public ListRentedBUL()
        {
            db = new ListRentedDAL();
        }
        public List<ListRented> ListRenteds()
        {
            return db.GetAllListRented();
        }
        public bool AddListRented(ListRented listRented)
        {
            return db.AddListRented(listRented);
        }
        public bool UpdateListRented(ListRented listRented)
        {
            return db.UpdateListRented(listRented);
        }
        public bool DeleteListRented(int idListRented)
        {
            return db.DeleteListRented(idListRented);
        }
    }
}
