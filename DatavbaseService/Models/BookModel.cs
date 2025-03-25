using DatavbaseService.Abstractions;

namespace DatavbaseService.Models;

public class BookModel : IModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    
    public List<AuthorModel>? Authors { get; set; }
    public List<BookModel>? Books { get; set; }
    
    public BookModel()
    {
        Authors = new List<AuthorModel>();
        Books = new List<BookModel>();
    }
    
    public BookModel(int id, string title)
    {
        Id = id;
        Title = title;
    }
    public BookModel(int id, string title, List<AuthorModel>? authors)
    {
        Id = id;
        Title = title;
        Authors = authors;
    }
    public BookModel(int id, string title, List<AuthorModel>? authors, List<BookModel>? books)
    {
        Id = id;
        Title = title;
        Authors = authors;
        Books = books;
    }
}