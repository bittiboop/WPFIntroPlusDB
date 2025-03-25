using DatavbaseService.Abstractions;

namespace DatavbaseService.Models;

public class AuthorModel : IModel
{
    public int AuthorID { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Country { get; set; }
    public List<LibraryModel>? Libraries { get; set; }
    
    public AuthorModel() { Libraries = new List<LibraryModel>(); }
    public AuthorModel(int authorID, string name, string surname, string country)
    {
        AuthorID = authorID;
        Name = name;
        Surname = surname;
        Country = country;
    }
    public AuthorModel(int authorID, string name, string surname, string country, List<LibraryModel>? libraries)
    {
        AuthorID = authorID;
        Name = name;
        Surname = surname;
        Country = country;
        Libraries = libraries;
    }
}