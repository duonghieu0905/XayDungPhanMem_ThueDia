using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DiskInfoReturn
    {
        public int IdDisk { get; set; }
        public int IdCustomer { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public DateTime RentedDate { get; set; }
        public DateTime ExpectedDate { get; set; }
       
    }
}
