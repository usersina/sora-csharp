using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoraApp.Entities;

public class Book : Artwork
{
    public string Synopsis { get; set; }
    public int PagesNumber { get; set; }

    // --------- Relations --------- //
    public Audio? Audio { get; set; }

    public ICollection<Genre> Genres { get; set; }

    // --------- Constructors --------- //
    public Book() { }

    //String title, double cost, String fileUrl, String coverImg, User user, String synopsis, int pagesNumber, List<Genre> genres
    public Book(string title, double cost, string fileUrl, string coverImg, User user, string synopsis, int pagesNumber, ICollection<Genre> genres) : base(title, cost, fileUrl, coverImg, user)
    {
        Synopsis = synopsis;
        PagesNumber = pagesNumber;
        Genres = genres;
    }
}
