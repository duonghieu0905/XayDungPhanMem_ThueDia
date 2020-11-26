using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Title
    {
        [Key]
        public int IdTitle { get; set; }
        public virtual DiskType DiskType { get; set; }
        public int IdDiskType { get; set; }
        public string NameTitle { get; set; }
        public int TotalDisk { get; set; }
        public int TotalDiskOnShelf { get; set; }
        public ICollection<Disk> Disks { get; set; }
    }
}
