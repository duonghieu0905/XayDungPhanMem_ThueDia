using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Title
    {
        [Key]
        public int IdTitle { get; set; }
        public virtual DiskType DiskType { get; set; }
        public int? IdDiskType { get; set; }
        public string NameTitle { get; set; }
        public int? TotalDiskOnShelf { get; set; }
        public ICollection<Disk> Disks { get; set; }
    }
}
