using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ListTitlePreOrder
    {
        [Key]
        public int IdListTitlePreOrder { get; set; }
        public virtual Customer Customer { get; set; }
        public int? IdCustomer { get; set; }
        public virtual Title Title { get; set; }
        public int? IdTitle { get; set; }
        public int? NumberOfDisk { get; set; }
        public string StatusProcess { get; set; }
        public ICollection<DetailPreOrder> DetailPreOrders { get; set; }
    }
}
