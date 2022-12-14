using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoraApp.Entities.Composite;

namespace SoraApp.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public double Credit { get; set; }
    public string? Phone { get; set; }
    public string? Birthday { get; set; }
    public string? Country { get; set; }

    // --------- Relations --------- //
    public ICollection<Genre> Genres { get; set; }

    public int? DesignationId { get; set; }
    public Designation? Designation { get; set; }

    public ICollection<Artwork> Artworks { get; set; }

    public ICollection<UserCollection> UserCollections { get; set; }

    public ICollection<ArtworkRating> ArtworkRatings { get; set; }

    // --------- Constructors --------- //
    public User() { }

    public User(string firstName, string lastName, string email, string username, string password, double credit)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Username = username;
        Password = password;
        Credit = credit;
    }

    public User(string firstName, string lastName, string email, string username, string password, double credit, ICollection<Genre> genres)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Username = username;
        Password = password;
        Credit = credit;
        Genres = genres;
    }

    public User(string firstName, string lastName, string email, string username, string password, double credit, Designation? designation)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Username = username;
        Password = password;
        Credit = credit;
        Designation = designation;
    }

    public User(string firstName, string lastName, string email, string username, string password, double credit, Designation? designation, ICollection<Genre> genres)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Username = username;
        Password = password;
        Credit = credit;
        Designation = designation;
        Genres = genres;
    }
}
