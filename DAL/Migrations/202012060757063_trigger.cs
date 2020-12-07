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
			Sql(@"CREATE TRIGGER update_lst_rented_return ON ListRenteds
					FOR UPDATE
					AS
					BEGIN
	
						declare @ActualReturnDateDelete datetime
						declare @ActualReturnDate datetime
						declare @StatusOnBillDelete nvarchar(max)
						declare @idListRented int
						declare @idDisk int
						declare @expecteddate datetime
						select top 1 @idDisk=IdDisk,@idListRented=d.IdListRented,@ActualReturnDateDelete=d.ActualReturnDate,@StatusOnBillDelete=d.StatusOnBill,@expecteddate=d.ExpectedReturnDate from deleted d
						
						select top 1 @ActualReturnDate=i.ActualReturnDate from inserted i
						IF @ActualReturnDateDelete is null
						BEGIN
							
							update Disks set DiskRentalStatus='OnShelf' where @idDisk=IdDisk
							
							declare @status nvarchar(max)
							IF @expecteddate<@ActualReturnDate set @status='Unpaid'
							ELSE set @status='Nope'
							update ListRenteds set StatusOnBill=@status where IdListRented=@idListRented

						END
					END
					");
			Sql(@"CREATE TRIGGER insert_detail_preorder ON DetailPreOrders
					FOR INSERT
					as
					begin
						declare @IdListTitlePreOrder int
						select top 1 @IdListTitlePreOrder=d.IdListTitlePreOrder from DetailPreOrders d
						update ListTitlePreOrders set NumberOfDisk=NumberOfDisk-1 where IdListTitlePreOrder=@IdListTitlePreOrder
					end");
			Sql(@"CREATE TRIGGER delete_detail_preorder on DetailPreOrders
				for delete
				as
				begin
					declare @IdListTitlePreOrder int
					declare @count int
					select top 1 @IdListTitlePreOrder=d.IdListTitlePreOrder from deleted d
					select @count=COUNT(*) from DetailPreOrders where @IdListTitlePreOrder=IdListTitlePreOrder
					IF @count=0
						update ListTitlePreOrders set StatusProcess='Completed' where IdListTitlePreOrder=@IdListTitlePreOrder
				end");
        }

        public override void Down()
        {

        }
    }
}
