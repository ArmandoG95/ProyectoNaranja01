using ProyectoNaranja.Entities;
using System.Data.Entity;

namespace ProyectoNaranja
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=miConexion")
        { 
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Adviser> Advisers { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Coordinator> Coordinators { get; set; }
        public DbSet<Time> Times { get; set; }
    }
}
