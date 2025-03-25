using DatavbaseService.Abstractions;

namespace DatavbaseService.Models;

public class LibraryModel : IModel
{
    int Id { get; set; }
    string? Name { get; set; }
    List<BookModel> Books { get; set; }
    List<AuthorModel> Authors { get; set; }

    
    public LibraryModel()
    {
        Books = new List<BookModel>();
        Authors = new List<AuthorModel>();
    }
}