using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using SoraApp.Entities.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoraApp.Entities;

public abstract class Artwork
{
    public int Id { get; set; }
    public String Title { get; set; }
    public double Cost { get; set; }
    public string FileUrl { get; set; }
    public string CoverImg { get; set; }
    public DateTime? PublishedAt { get; set; }

    // --------- Relations --------- //
    public int UserId { get; set; }
    public User User { get; set; }

    public ICollection<UserCollection> UserCollections { get; set; }

    public ICollection<ArtworkReview> ArtworkReviews { get; set; }

    public ICollection<ArtworkRating> ArtworkRatings { get; set; }

    // --------- Constructors --------- //
    public Artwork() { }

    protected Artwork(string title, double cost, string fileUrl, string coverImg, User user)
    {
        Title = title;
        Cost = cost;
        FileUrl = fileUrl;
        CoverImg = coverImg;
        User = user;
    }
}
