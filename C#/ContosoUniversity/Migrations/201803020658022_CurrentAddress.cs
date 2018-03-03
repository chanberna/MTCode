namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CurrentAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Address");
        }
    }
}
