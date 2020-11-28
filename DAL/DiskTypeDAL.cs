using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DiskTypeDAL
    {
        private QuanLyThueDiaDBContext context;
        public DiskTypeDAL()
        {
            context = new QuanLyThueDiaDBContext();
        }
        public List<DiskType> GetAllDiskType()
        {
            return context.DiskTypes.ToList();
        }
        public bool AddDiskType(DiskType diskType)
        {
            context.DiskTypes.Add(diskType);
            context.SaveChanges();
            return true;
        }
        public bool UpdateDiskType(DiskType diskType)
        {
            DiskType diskTypeUpdate = context.DiskTypes.Find(diskType.IdDiskType);
            diskTypeUpdate.LateFee = diskType.LateFee;
            diskTypeUpdate.Price = diskType.Price;
            diskTypeUpdate.TimeRented = diskType.TimeRented;
            diskTypeUpdate.TypeName = diskType.TypeName;
            context.SaveChanges();
            return true;
        }
        public bool DeleteDiskType(int idDiskType)
        {
            DiskType diskTypeDelete = context.DiskTypes.Find(idDiskType);
            context.DiskTypes.Remove(diskTypeDelete);
            context.SaveChanges();
            return true;
        }
    }
}
