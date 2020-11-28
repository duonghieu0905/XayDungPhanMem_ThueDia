using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ListRented
    {
        [Key]
        public int IdListRented { get; set; }
        public virtual Disk Disk { get; set; }
        public int? IdDisk { get; set; }
        public virtual Customer Customer { get; set; }
        public int? IdCustomer { get; set; }
        public double? LateFee { get; set; }
        public DateTime? RentalDate { get; set; }
        public DateTime? ExpectedReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public string StatusOnBill { get; set; }
    }
}
