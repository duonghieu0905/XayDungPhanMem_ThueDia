using DAL;
using Entities;
using System.Collections.Generic;
namespace BUL
{
    public class ListTitlePreOrderBUL
    {
        private ListTitlePreOrderDAL db;
        public ListTitlePreOrderBUL()
        {
            db = new ListTitlePreOrderDAL();
        }
        public List<ListTitlePreOrder> GetListTitlePreOrders()
        {
            return db.GetAllListTitlePreOrder();
        }
        public bool AddListTitlePreOrder(ListTitlePreOrder listTitlePreOrder)
        {
            return db.AddListTitlePreOrder(listTitlePreOrder);
        }
        public bool UpdateListTitlePreOrder(ListTitlePreOrder listTitlePreOrder)
        {
            return db.UpdateListTitlePreOrder(listTitlePreOrder);
        }
        public bool DeleteListTitlePreOrder(int idListTitlePreOrder)
        {
            return db.DeleteListTitlePreOrder(idListTitlePreOrder);
        }
    }
}
