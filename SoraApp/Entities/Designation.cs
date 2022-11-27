using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoraApp.Entities;

public class Designation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float BonusPerc { get; set; }

    // --------- Relations --------- //
    public ICollection<User> Users { get; set; }

    // --------- Constructors --------- //
    public Designation(string name, string description, float bonusPerc)
    {
        Name = name;
        Description = description;
        BonusPerc = bonusPerc;
    }
}
