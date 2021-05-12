namespace ProyectoNaranja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestMig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Advisers", "Correo", c => c.String(maxLength: 30));
            AlterColumn("dbo.Advisers", "Department", c => c.String(maxLength: 30));
            AlterColumn("dbo.Advisers", "Photo", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Advisers", "Photo", c => c.String());
            AlterColumn("dbo.Advisers", "Department", c => c.String());
            AlterColumn("dbo.Advisers", "Correo", c => c.String());
        }
    }
}
