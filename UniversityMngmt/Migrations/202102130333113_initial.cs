namespace UniversityMngmt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentAccounts",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        AccountName = c.String(nullable: false),
                        AccountDescription = c.String(),
                        AccountBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.AccountId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentAccounts");
        }
    }
}
