using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class CustomerDAL
    {
        QuanLyThueDiaDBContext context;
        public CustomerDAL()
        {
            context = new QuanLyThueDiaDBContext();
        }
        public List<Customer> GetAllCustomer()
        {
            return context.Customers.ToList();
        }
        public bool AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return true;

        }
        public bool UpdateCustomer(Customer customer)
        {
            Customer customerUpdate = context.Customers.Find(customer.IdCustomer);
            customerUpdate.Address = customer.Address;
            customerUpdate.CustomerName = customer.CustomerName;
            customerUpdate.PhoneNumber = customer.PhoneNumber;
            context.SaveChanges();
            return true;
        }
        public bool DeleteCustomer(int idCustomer)
        {
            Customer customerDelete = context.Customers.Find(idCustomer);
            context.Customers.Remove(customerDelete);
            context.SaveChanges();
            return true;
        }
    }
}
