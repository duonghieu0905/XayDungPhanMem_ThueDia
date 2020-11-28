using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class DetailPreOrder
    {
        [Key]
        public int IdDetailPreOrder { get; set; }
        public virtual Customer Customer { get; set; }
        public int? IdCustomer { get; set; }
        public virtual Disk Disk { get; set; }
        public int? IdDisk { get; set; }
        public virtual ListTitlePreOrder ListTitlePreOrder { get; set; }
        public int? IdListTitlePreOrder { get; set; }
    }
}
