namespace ProyectoNaranja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contact : DbMigration
    {
        public override void Up()
        {
            
            AlterColumn("dbo.Coordinators", "PhoneNumber", c => c.String(maxLength: 30));
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Coordinators", "PhoneNumber", c => c.String());

        }
    }
}
