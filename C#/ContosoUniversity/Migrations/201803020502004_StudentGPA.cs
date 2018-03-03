namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentGPA : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "StudentGPA", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "StudentGPA");
        }
    }
}
