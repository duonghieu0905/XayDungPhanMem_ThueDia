using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public Disk GetDisk(int idDisk)
        {
            return context.Disks.Find(idDisk);
        }
        public bool AddDisk(Disk disk)
        {
            try
            {
                context.Disks.Add(disk);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateDisk(Disk disk)
        {
            try
            {
                Disk diskUpdate = context.Disks.Find(disk.IdDisk);
                diskUpdate.IdTitle = disk.IdTitle;
                diskUpdate.DiskStatus = disk.DiskStatus;
                diskUpdate.DiskRentalStatus = disk.DiskRentalStatus;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteDisk(int idDisk)
        {
            try
            {
                Disk diskDelete = context.Disks.Find(idDisk);
                if (diskDelete.DiskRentalStatus.Equals("Rented") || diskDelete.DiskRentalStatus.Equals("OnHold"))
                    return false;
                context.Disks.Remove(diskDelete);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
