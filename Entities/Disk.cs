using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Disk
    {

        [Key]
        public int IdDisk { get; set; }
        public virtual Title Title { get; set; }
        public int? IdTitle { get; set; }
        public string DiskRentalStatus { get; set; }
        public string DiskStatus { get; set; }
    }
}
