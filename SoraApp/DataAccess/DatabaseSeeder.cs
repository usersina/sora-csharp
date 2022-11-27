using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SoraApp.Entities;
using SoraApp.Entities.Composite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoraApp.DataAccess;

public class DatabaseSeeder
{
    private ApplicationDbContext dbContext;

    public DatabaseSeeder(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void PopulateDatabase()
    {
        Debug.WriteLine("------------- Populating base data -------------");

        // Create designations
        EntityEntry<Designation> fanDesignation = dbContext.Add(new Designation("Fan", "You never published any content", 0));
        dbContext.Add(new Designation("Novice", "You published very little content", 2));
        dbContext.Add(new Designation("Amateur", "You published some content", 5));
        EntityEntry<Designation> novelist = dbContext.Add(new Designation("Novelist", "You published enough books to be called a novelist", 20));
        dbContext.Add(new Designation("Quill-Driver", "You published a great deal of book", 30));

        // Create genres
        EntityEntry<Genre> fantasyGenre = dbContext.Add(new Genre("Fantasy", "Supernatural and out of this world"));
        EntityEntry<Genre> romanceGenre = dbContext.Add(new Genre("Romance", "It's all about relations"));
        EntityEntry<Genre> scienceGenre = dbContext.Add(new Genre("Science", "Related to the collective knowledge we share as humans"));
        EntityEntry<Genre> scifiGenre = dbContext.Add(new Genre("Sci-fi", "Set out in the supposedly not so distance future"));

        // Create users
        EntityEntry<User> johnUser = dbContext.Add(new User("John", "Writer", "john.writer@gmail.com", "jwriter", "password", 340, novelist.Entity));
        EntityEntry<User> barrelUser = dbContext.Add(
            new User(
                "Barrel", "Reader", "barrel.reader@gmail.com", "breader", "password", 120, fanDesignation.Entity,
                new Genre[] { fantasyGenre.Entity, romanceGenre.Entity, scienceGenre.Entity })
            );

        // Create reviewer
        EntityEntry<Reviewer> kyoumaReviewer = dbContext.Add(
            new Reviewer(
                "Kyouma", "Viewer", "kyouma.viewer@gmail.com", "hououin", "password", 0, DateTime.Now,
                new Genre[] { scienceGenre.Entity, fantasyGenre.Entity, scifiGenre.Entity })
            );

        // Create two books for John
        EntityEntry<Book> timeTravelBook = dbContext.Add(
            new Book(
                "Time Travel for Dummies", 180, "https://some-site-or-service/time-travel-for-dummies.pdf",
                "https://some-covers/image.png", johnUser.Entity,
                "The all-in one Time Travel book that even toddlers should be able to understand",
                250, new Genre[] { scienceGenre.Entity })
            );
        dbContext.Add(
            new Book(
                "Lord of the Donuts", 260, "https://some-site-or-service/lord-of-the-donuts.pdf",
                "https://some-covers/image.png", johnUser.Entity,
                "In the magical world of Tunod, a strange curse is turning criminals into donuts",
                500, new Genre[] { fantasyGenre.Entity })
            );

        // Add audio for the first book
        EntityEntry<Audio> timetravelAudio = dbContext.Add(
            new Audio(
                "Time Travel - Audio", 50, "https://path-to-some-mp3-server/time-travel-for-dummies.mp3",
                "https://some-covers/image.png", johnUser.Entity,
                "Reading out the book for you to make time travel even simpler", 22500, timeTravelBook.Entity)
            );
        timetravelAudio.Entity.PublishedAt = DateTime.Now;

        // Add a podcast to the reviewer
        EntityEntry<Audio> timetravelPodcast = dbContext.Add(
            new Audio(
                "Time Travel - Podcast", 25, "https://path-to-some-mp3-server/discussing-time-traver-for-dummies.mp3",
                "https://some-covers/image.png", kyoumaReviewer.Entity,
                "Kyouma, your host will discuss Time Travel for Dummies", 1200, null)
            );
        timetravelPodcast.Entity.PublishedAt = DateTime.Now;

        // "Kyouma Viewer" create review for "Time Travel for Dummies"
        dbContext.Add(
            new ArtworkReview(
                "This book is GOLDEN. Published!", "Hear my new Podcast about it if you're interested!",
                true, kyoumaReviewer.Entity, timeTravelBook.Entity)
            );
        // Actually publish the book
        timeTravelBook.Entity.PublishedAt = DateTime.Now;

        // "Barrel Reader": Add book to user-collections
        dbContext.Add(new UserCollection(DateTime.Now, barrelUser.Entity, timeTravelBook.Entity));

        // "Barrel Reader": Create review for "Time Travel for Dummies"
        dbContext.Add(
            new ArtworkRating(
                5, "This book has some interesting things, but also a tag of sci-fi should be added.",
                barrelUser.Entity, timeTravelBook.Entity)
            );

        // Commit all the changes
        dbContext.SaveChanges();

        Debug.WriteLine("------------- Database populated successfully -------------");
    }
}
