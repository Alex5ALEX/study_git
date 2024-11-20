using Auto_Rent.Models;
using Microsoft.EntityFrameworkCore;

namespace Auto_Rent.Data;


public class ApplicationDbContext : DbContext
{
    public DbSet<AutoEntity> Auto { get; set; }//добавление таблицы в бд

    public DbSet<ClientEntity> Client { get; set; }

    public DbSet<EmployeeEntity> Employee { get; set; }

    public DbSet<OrderEntity> Order { get; set; }

    public DbSet<ProviderEntity> Provider { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
        var connectionString = "server=localhost;port=3306;database=AutoRent;user id=root;password=BuildSQLData;";

        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

}

