using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class DiskType
    {
        [Key]
        public int IdDiskType { get; set; }
        public string TypeName { get; set; }
        public int? TimeRented { get; set; }
        public double? LateFee { get; set; }
        public double? Price { get; set; }
        public ICollection<Title> Titles { get; set; }
    }
}
