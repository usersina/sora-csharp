using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SoraApp.Entities.Composite;

[Comment("Artworks that the user has bought (not created)")]
[Table("user_collections")]
public class UserCollection
{
    public int Id { get; set; } // Using foreign keys as composite key needs some effort
    public DateTime BoughtAt { get; set; }
    public DateTime? LastSeenAt { get; set; }
    [Comment("Relevant only if artwork is an Audio, in milliseconds")]
    public int? DurationCheckpoint { get; set; }
    [Comment("Relevant only if artwork is a Book")]
    public int? PageCheckpoint { get; set; }

    // --------- Relations --------- //
    public int UserId { get; set; }
    public User User { get; set; }

    public int ArtworkId { get; set; }
    public Artwork Artwork { get; set; }

    // --------- Constructors --------- //
    public UserCollection() { }

    public UserCollection(DateTime boughtAt, User user, Artwork artwork)
    {
        BoughtAt = boughtAt;
        User = user;
        Artwork = artwork;

        if (Artwork.GetType() == typeof(Book))
        {
            PageCheckpoint = 0;
        }
        else if (Artwork.GetType() == typeof(Audio))
        {
            DurationCheckpoint = 0;
        }
    }
}
