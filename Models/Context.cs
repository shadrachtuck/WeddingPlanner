using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Models
{
    public class Context : DbContext
    {
     public Context(DbContextOptions options) : base(options) { }
     public DbSet<User> users {get;set;}
     public DbSet<Wedding> weddings {get;set;}
     public DbSet<Reservation> reservations {get;set;}
    }
}