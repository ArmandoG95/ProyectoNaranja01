namespace ProyectoNaranja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contact : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "LastName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Contacts", "PhoneNumber", c => c.String(maxLength: 30));
            AlterColumn("dbo.Contacts", "Photo", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Photo", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Contacts", "PhoneNumber", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
