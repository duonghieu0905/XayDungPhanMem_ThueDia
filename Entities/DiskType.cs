using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DiskType
    {
        [Key]
        public int IdDiskType { get; set; }
        public int TypeName { get; set; }
        public int TimeRented { get; set; }
        public double LateFee { get; set; }
        public double Price { get; set; }
        public ICollection<Title> Titles { get; set; }
    }
}
