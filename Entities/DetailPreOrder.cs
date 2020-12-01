using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class DetailPreOrder
    {
        [Key]
        [DisplayName("Mã Chi Tiết Đặt Trước")]
        public int IdDetailPreOrder { get; set; }
        public virtual Customer Customer { get; set; }
        [DisplayName("Mã Khách Hàng")]
        public int? IdCustomer { get; set; }
        public virtual Disk Disk { get; set; }
        [DisplayName("Mã Đĩa Bản Sao")]
        public int? IdDisk { get; set; }
        public virtual ListTitlePreOrder ListTitlePreOrder { get; set; }
        public int? IdListTitlePreOrder { get; set; }
    }
}
