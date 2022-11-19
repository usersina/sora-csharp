using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoraApp.Entities;

public class Book : Artwork
{
    public string Title { get; set; }
    public string Synopsis { get; set; }
    public int PagesNumber { get; set; }

    // --------- Relations --------- //

    public Audio? Audio { get; set; }

    public ICollection<Genre> Genres { get; set; }
}
