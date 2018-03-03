namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreditsEarned : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "CreditsEarned", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "CreditsEarned");
        }
    }
}
