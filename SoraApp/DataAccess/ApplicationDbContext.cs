using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.Extensions.Options;
using SoraApp.Entities;
using System;
using System.Collections.Generic;
using System.Configuration.Abstractions;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoraApp.DataAccess;

public class ApplicationDbContext : DbContext
{
    private readonly string connectionString;

    public DbSet<User> Users { get; set; }
    public DbSet<Reviewer> Reviewers { get; set; }

    public ApplicationDbContext()
    {
        connectionString = ConfigurationManager.Instance.ConnectionStrings[1].ToString();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Debug.WriteLine("OnConfiguring was called!");
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect("Server=localhost;Database=sora_csharp;Uid=root;Pwd=;"));
    }

    //public ApplicationDbContext(string connectionString) : base(GetOptions(connectionString)) { }

    //private static DbContextOptions GetOptions(string connectionString)
    //{
    //    return MySqlDbContextOptionsBuilderExtensions.UseMySql(new DbContextOptionsBuilder(), ServerVersion.AutoDetect(connectionString)).Options;
    //}
}
