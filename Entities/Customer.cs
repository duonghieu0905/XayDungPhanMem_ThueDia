using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
