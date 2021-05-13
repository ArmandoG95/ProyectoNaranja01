 namespace ProyectoNaranja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coordinators", "Correo", c => c.String(maxLength: 30));
            AlterColumn("dbo.Coordinators", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Students", "Correo", c => c.String(maxLength: 30));
            AlterColumn("dbo.Students", "Photo", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Photo", c => c.String(maxLength: 30));
            AlterColumn("dbo.Students", "Correo", c => c.String());
            AlterColumn("dbo.Coordinators", "Photo", c => c.String(maxLength: 30));
            AlterColumn("dbo.Coordinators", "Correo", c => c.String());
        }
    }
}
