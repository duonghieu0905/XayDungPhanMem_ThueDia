namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class trigger : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE TRIGGER trigger_insert_disk ON Disks
                    FOR INSERT
                    AS
                    BEGIN
	                    declare @idTitle int
	                    declare @count int
	                    select top 1 @idTitle=IdTitle from inserted
	                    select @count=COUNT(*) from Disks where @idTitle=IdTitle and DiskRentalStatus='OnShelf'
	                    update Titles set TotalDiskOnShelf=@count where IdTitle=@idTitle
                    END");
            Sql(@"CREATE TRIGGER add_lst_rented ON ListRenteds
                    FOR INSERT
                    AS
                    BEGIN
	                    declare @idDisk int
	                    declare @ActualReturnDate datetime
	                    declare @StatusOnBill nvarchar(max)
	                    select top 1 @idDisk=i.IdDisk,@ActualReturnDate=i.ActualReturnDate,@StatusOnBill=i.StatusOnBill from inserted i
	                    IF @ActualReturnDate is null and @StatusOnBill is null
	                    update Disks set DiskRentalStatus='Rented' where IdDisk=@idDisk
                    END");
        }

        public override void Down()
        {

        }
    }
}
