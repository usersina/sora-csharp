using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoraApp.Entities;

[Comment("Either an AudioBook or a Podcast depending on the book reference")]
public class Audio : Artwork
{
    public string Description { get; set; }

    [Comment("Duration of the audio in milliseconds")]
    public int Duration { get; set; }

    // --------- Relations --------- //
    public int? BookId { get; set; }

    public Book? Book { get; set; }

    // --------- Constructors --------- //
    public Audio() { }

    public Audio(string title, double cost, string fileUrl, string coverImg, User user, string description, int duration, Book? book) : base(title, cost, fileUrl, coverImg, user)
    {
        Description = description;
        Duration = duration;
        Book = book;
    }
}
