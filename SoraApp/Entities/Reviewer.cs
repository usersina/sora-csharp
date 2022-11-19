using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoraApp.Entities.Composite;

namespace SoraApp.Entities;

public class Reviewer : User
{
    public DateTime? VerifiedAt { get; set; }

    // --------- Relations --------- //

    public ICollection<ArtworkReview> ArtworkReviews { get; set; }
}
