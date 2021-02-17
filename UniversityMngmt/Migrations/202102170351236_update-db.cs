namespace UniversityMngmt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.StudentAccounts", newName: "StudentFinanceAccts");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.StudentFinanceAccts", newName: "StudentAccounts");
        }
    }
}
