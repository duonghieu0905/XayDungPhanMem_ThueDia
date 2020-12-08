using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ListTitlePreOrderDAL
    {
        private QuanLyThueDiaDBContext context;
        public ListTitlePreOrderDAL()
        {
            context = new QuanLyThueDiaDBContext();
        }
        public List<ListTitlePreOrder> GetAllListTitlePreOrder()
        {
            return context.ListTitlePreOrders.ToList();
        }
        public ListTitlePreOrder GetListTitlePreOrder(int idListTitlePreOrder)
        {
            return context.ListTitlePreOrders.Find(idListTitlePreOrder);
        }
        public bool AddListTitlePreOrder(ListTitlePreOrder listTitlePreOrder)
        {
            context.ListTitlePreOrders.Add(listTitlePreOrder);
            context.SaveChanges();
            return true;
        }
        public bool UpdateListTitlePreOrder(ListTitlePreOrder listTitlePreOrder)
        {
            ListTitlePreOrder listTitlePreOrderUpdate = context.ListTitlePreOrders.Find(listTitlePreOrder.IdListTitlePreOrder);
            listTitlePreOrderUpdate.NumberOfDisk = listTitlePreOrder.NumberOfDisk;
            listTitlePreOrderUpdate.IdCustomer = listTitlePreOrder.IdCustomer;
            listTitlePreOrderUpdate.IdTitle = listTitlePreOrder.IdTitle;
            listTitlePreOrderUpdate.StatusProcess = listTitlePreOrder.StatusProcess;
            context.SaveChanges();
            return true;
        }
        public bool DeleteListTitlePreOrder(int idListTitlePreOrder)
        {
            ListTitlePreOrder listTitlePreOrderDelete = context.ListTitlePreOrders.Find(idListTitlePreOrder);
            context.ListTitlePreOrders.Remove(listTitlePreOrderDelete);
            context.SaveChanges();
            return true;
        }
    }
}
