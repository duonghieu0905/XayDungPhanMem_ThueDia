namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trigger : DbMigration
    {
        public override void Up()
        {
            Sql(@"create trigger ");

        }
        
        public override void Down()
        {

        }
    }
}
