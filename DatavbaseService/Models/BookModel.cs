using DatavbaseService.Abstractions;

namespace DatavbaseService.Models;

public class BookModel : IModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public AuthorModel? Author { get; set; }
    
    public BookModel()
    {
        Author = new AuthorModel();    
    }

    public BookModel(int id, string title)
    {
        Id = id;
        Title = title;
    }
    public BookModel(int id, string title, AuthorModel author)
    {
        Id = id;
        Title = title;
        Author = author;
    }
}