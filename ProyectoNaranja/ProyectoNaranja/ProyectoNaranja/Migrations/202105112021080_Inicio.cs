namespace ProyectoNaranja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advisers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(maxLength: 30),
                        PhoneNumber = c.String(maxLength: 30),
                        CellPhoneNumber = c.String(maxLength: 30),
                        Correo = c.String(),
                        Department = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(maxLength: 30),
                        PhoneNumber = c.String(maxLength: 30),
                        CellPhoneNumber = c.String(maxLength: 30),
                        Correo = c.String(maxLength: 30),
                        Photo = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Address = c.String(nullable: false, maxLength: 100),
                        PostalCode = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 30),
                        Photo = c.String(),
                        Correo = c.String(),
                        Website = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 30),
                        CellphoneNumber = c.String(maxLength: 250),
                        Correo = c.Int(nullable: false),
                        Photo = c.String(nullable: false, maxLength: 30),
                        Department = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coordinators",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(maxLength: 30),
                        CellPhoneNumber = c.String(maxLength: 30),
                        PhoneNumber = c.String(maxLength: 30),
                        Correo = c.String(maxLength: 30),
                        Photo = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Majors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 50),
                        Photo = c.String(maxLength: 25),
                        Correo = c.String(),
                        Description = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(maxLength: 30),
                        PhoneNumber = c.String(maxLength: 30),
                        CellPhoneNumber = c.String(maxLength: 30),
                        Correo = c.String(),
                        Photo = c.String(maxLength: 30),
                        Birthdate = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Times",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(maxLength: 30),
                        PhoneNumber = c.String(maxLength: 30),
                        CellPhoneNumber = c.String(maxLength: 30),
                        Correo = c.String(),
                        Department = c.String(),
                        Photo = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Times");
            DropTable("dbo.Students");
            DropTable("dbo.Majors");
            DropTable("dbo.Coordinators");
            DropTable("dbo.Contacts");
            DropTable("dbo.Companies");
            DropTable("dbo.Coaches");
            DropTable("dbo.Advisers");
        }
    }
}
