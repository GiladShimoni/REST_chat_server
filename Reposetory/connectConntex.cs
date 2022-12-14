using Domain;
using Microsoft.EntityFrameworkCore;
namespace Reposetory;

public class ConnectContext : DbContext
{
    private const string connectionString = "server=localhost;port=3306;database=connect_db;user=root;password=123321";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseMySql(connectionString, MariaDbServerVersion.AutoDetect(connectionString));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
// Configuring the Name property as the primary
// key of the Items table
//modelBuilder.Entity<User>().HasKey(e => e.id);
//modelBuilder.Entity<Contact>().HasKey(e => e.Id);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Ratings> Ratings { get; set; }
}

