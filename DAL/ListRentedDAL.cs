using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ListRentedDAL
    {
        QuanLyThueDiaDBContext context;
        public ListRentedDAL()
        {
            context = new QuanLyThueDiaDBContext();
        }
        public List<ListRented> GetAllListRented()
        {
            return context.ListRenteds.ToList();
        }
        public bool AddListRented(ListRented listRented)
        {
            context.ListRenteds.Add(listRented);
            context.SaveChanges();
            return true;
        }
        public bool UpdateListRented(ListRented listRented)
        {
            ListRented listRentedUpdate = context.ListRenteds.Find(listRented.IdListRented);
            listRentedUpdate.IdDisk = listRented.IdDisk;
            listRentedUpdate.IdCustomer = listRented.IdCustomer;
            listRentedUpdate.LateFee = listRented.LateFee;
            listRentedUpdate.RentalDate = listRented.RentalDate;
            listRentedUpdate.ExpectedReturnDate = listRented.ExpectedReturnDate;
            listRentedUpdate.ActualReturnDate = listRented.ActualReturnDate;
            listRentedUpdate.StatusOnBill = listRented.StatusOnBill;
            context.SaveChanges();
            return true;
        }
        public bool DeleteListRented(int idListRented)
        {
            ListRented listRentedDelete = context.ListRenteds.Find(idListRented);
            context.ListRenteds.Remove(listRentedDelete);
            context.SaveChanges();
            return true;
        }
    }
}
