using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DiskDAL
    {
        QuanLyThueDiaDBContext context;
        public DiskDAL()
        {
            context = new QuanLyThueDiaDBContext();
        }
        
        public List<Disk> GetAllDisk()
        {
            return context.Disks.ToList();
        }
        public bool AddDisk(Disk disk)
        {
            context.Disks.Add(disk);
            context.SaveChanges();
            return true;
        }
        public bool UpdateDisk(Disk disk)
        {
            Disk diskUpdate = context.Disks.Find(disk.IdDisk);
            diskUpdate.IdTitle = disk.IdTitle;
            diskUpdate.DiskStatus = disk.DiskStatus;
            diskUpdate.DiskRentalStatus = disk.DiskRentalStatus;
            context.SaveChanges();
            return true;
        }
        public bool DeleteDisk(int idDisk)
        {
            Disk diskDelete = context.Disks.Find(idDisk);
            context.Disks.Remove(diskDelete);
            context.SaveChanges();
            return true;
        }
    }
}
