namespace UniversityMngmt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatbseUpdatea : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentFinanceAccts", "AccountBalance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentFinanceAccts", "AccountBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
