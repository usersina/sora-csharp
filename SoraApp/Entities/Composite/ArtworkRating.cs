using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoraApp.Entities.Composite;

[Comment("Artworks that the User rated")]
[Table("artwork_ratings")]
public class ArtworkRating
{
    public int Id { get; set; } // Using foreign keys as composite key needs some effort

    public int Score { get; set; }

    public string Content { get; set; }

    // --------- Relations --------- //
    public int ArtworkId { get; set; }
    public Artwork Artwork { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    // --------- Constructors --------- //
    public ArtworkRating() { }

    public ArtworkRating(int score, String content, User user, Artwork artwork)
    {
        Score = score;
        Content = content;
        User = user;
        Artwork = artwork;
    }
}
