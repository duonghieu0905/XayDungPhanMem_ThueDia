using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Customer
    {
        [Key]
        public int IdCustomer { get; set; }
        public string Address { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<ListRented> ListRenteds { get; set; }
        public ICollection<ListTitlePreOrder> ListTitlePreOrders { get; set; }
    }
}
