using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Disk
    {

        [Key]
        public int IdDisk { get; set; }
        public virtual Title Title { get; set; }
        public int IdTitle { get; set; }
        public int DiskRentalStatus { get; set; }
        public string DiskStatus { get; set; }
    }
}
