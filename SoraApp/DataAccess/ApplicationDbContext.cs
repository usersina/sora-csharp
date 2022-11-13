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
    public DbSet<Book> Books { get; set; }
    public DbSet<Audio> Audios { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Designation> Designations { get; set; }
    public DbSet<UserCollection> UserCollections { get; set; }
    public DbSet<ArtworkReview> ArtworkReviews { get; set; }
    public DbSet<ArtworkRating> ArtworkRatings { get; set; }

    public ApplicationDbContext()
    {
        connectionString = ConfigurationManager.Instance.ConnectionStrings[1].ToString();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(left => left.Genres)
            .WithMany(right => right.Users)
            .UsingEntity(join => join.ToTable("interests"));
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Debug.WriteLine("OnConfiguring was called!");
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    //public ApplicationDbContext(string connectionString) : base(GetOptions(connectionString)) { }

    //private static DbContextOptions GetOptions(string connectionString)
    //{
    //    return MySqlDbContextOptionsBuilderExtensions.UseMySql(new DbContextOptionsBuilder(), ServerVersion.AutoDetect(connectionString)).Options;
    //}
}
