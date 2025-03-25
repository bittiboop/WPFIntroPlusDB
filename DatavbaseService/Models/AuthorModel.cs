using DatavbaseService.Abstractions;

namespace DatavbaseService.Models;

public class AuthorModel : IModel
{
    public int AuthorID { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Country { get; set; }
    public List<BookModel> Books { get; set; }
    
    public AuthorModel() { Books = new List<BookModel>(); }
    public AuthorModel(int authorID, string name, string surname, string country)
    {
        AuthorID = authorID;
        Name = name;
        Surname = surname;
        Country = country;
    }
    public AuthorModel(int authorID, string name, string surname, string country, List<BookModel> books)
    {
        AuthorID = authorID;
        Name = name;
        Surname = surname;
        Country = country;
        Books = books;
    }
}