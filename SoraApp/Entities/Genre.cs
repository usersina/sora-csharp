using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoraApp.Entities;

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // --------- Relations --------- //

    public ICollection<User> Users { get; set; }

    public ICollection<Book> Books { get; set; }

    public Genre(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
