using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class DiskType
    {
        [Key]
        [DisplayName("Mã Loại Đĩa")]
        public int IdDiskType { get; set; }
        [DisplayName("Tên Loại Đĩa")]
        public string TypeName { get; set; }
        [DisplayName("Thời Gian Cho Thuê")]
        public int? TimeRented { get; set; }
        [DisplayName("Phí Trễ")]
        public double? LateFee { get; set; }
        [DisplayName("Phí Thuê")]
        public double? Price { get; set; }
        public ICollection<Title> Titles { get; set; }
    }
}
