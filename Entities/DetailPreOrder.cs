using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DetailPreOrder
    {
        [Key]
        public int IdDetailPreOrder { get; set; }
        public virtual Customer Customer { get; set; }
        public int IdCustomer { get; set; }
        public virtual Disk Disk { get; set; }
        public int IdDisk { get; set; }
        public virtual ListTitlePreOrder ListTitlePreOrder { get; set; }
        public int IdListTitlePreOrder { get; set; }
    }
}
