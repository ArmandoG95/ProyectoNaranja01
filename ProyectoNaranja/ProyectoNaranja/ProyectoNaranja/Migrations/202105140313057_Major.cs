namespace ProyectoNaranja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Major : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coordinators", "PhoneNumber", c => c.String(maxLength: 30));
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coordinators", "LastName", c => c.String());
            AlterColumn("dbo.Students", "PhoneNumber", c => c.String());
        }
    }
    
}
