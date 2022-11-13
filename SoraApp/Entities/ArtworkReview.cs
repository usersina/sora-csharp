using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoraApp.Entities;

[Comment("Artworks reviews for the Reviewer")]
[Table("artwork_reviews")]
public class ArtworkReview
{
    public int Id { get; set; } // Using foreign keys as composite key needs some effort
    public string Summary { get; set; }
    public string? Details { get; set; }
    public bool CanBePublished { get; set; }

    // --------- Relations --------- //

    public int ArtworkId { get; set; }
    public Artwork Artwork { get; set; }

    public int ReviewerId { get; set; }
    public Reviewer Reviewer { get; set; }
}
