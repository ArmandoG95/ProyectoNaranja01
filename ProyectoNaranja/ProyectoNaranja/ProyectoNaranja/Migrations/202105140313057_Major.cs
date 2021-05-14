﻿namespace ProyectoNaranja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Major : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coordinators", "PhoneNumber", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coordinators", "PhoneNumber");
        }
    }
}
