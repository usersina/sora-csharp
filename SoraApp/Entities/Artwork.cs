using Microsoft.EntityFrameworkCore;
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
    public double Cost { get; set; }
    public string FilePath { get; set; }
    public DateTime? PublishedAt { get; set; }

    // --------- Relations --------- //

    public int UserId { get; set; }
    public User User { get; set; }

    public ICollection<UserCollection> UserCollections { get; set; }

    public ICollection<ArtworkReview> ArtworkReviews { get; set; }

    public ICollection<ArtworkRating> ArtworkRatings { get; set; }
}
