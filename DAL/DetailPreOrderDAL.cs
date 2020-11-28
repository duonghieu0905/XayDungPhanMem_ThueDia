using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DetailPreOrderDAL
    {
        private QuanLyThueDiaDBContext context;
        public DetailPreOrderDAL()
        {
            context= new QuanLyThueDiaDBContext();
        }
        public List<DetailPreOrder> GetAllDetailPreOrderDAL()
        {
            return context.DetailPreOrders.ToList();
        }
        public bool AddDetailPreOrderDAL(DetailPreOrder detailpreorder)
        {
            context.DetailPreOrders.Add(detailpreorder);
            context.SaveChanges();
            return true;
            //trigger giam so luong list
            //trigger cap nhat lai trang thai cua dia
        }
        public bool UpdateDetailPreOrderDAL(DetailPreOrder detailPreOrder)
        {
            DetailPreOrder detailPreOrderUpdate = context.DetailPreOrders.Find(detailPreOrder.IdDetailPreOrder);
            detailPreOrderUpdate.IdDisk = detailPreOrder.IdDisk;
            detailPreOrderUpdate.IdListTitlePreOrder = detailPreOrder.IdListTitlePreOrder;
            detailPreOrderUpdate.IdCustomer = detailPreOrder.IdCustomer;
            context.SaveChanges();
            return true;
        }
        public bool DeleteDetailPreOrderDAL(int idDetailPreOrder)
        {
            DetailPreOrder detailPreOrderDelete = context.DetailPreOrders.Find(idDetailPreOrder);
            context.DetailPreOrders.Remove(detailPreOrderDelete);
            context.SaveChanges();
            return true;
        }
        public bool DeleteDetailPreOrderOfCustomerDAL(int idCustomer)
        {
            IQueryable<DetailPreOrder> listDelete = context.DetailPreOrders.Where(x => x.IdCustomer == idCustomer);
            context.DetailPreOrders.RemoveRange(listDelete);
            context.SaveChanges();
            return true;
        }
    }

}
