using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Division> Divisions { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<MyViewModel> MyViewModel { get; set; }
    }
}
