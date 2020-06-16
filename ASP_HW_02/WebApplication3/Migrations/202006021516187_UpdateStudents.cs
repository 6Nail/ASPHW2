namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudents : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "LastName");
        }
    }
}
