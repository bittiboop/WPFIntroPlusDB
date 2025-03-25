using DatavbaseService.Abstractions;

namespace DatavbaseService.Models;

public class ReaderModel : IModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? ReaderCardNumber { get; set; }
    public List<BookModel> Books { get; set; }

    public ReaderModel()
    {
        Books = new List<BookModel>();
    }
    
    public ReaderModel(int id, string name, string surname, string readerCardNumber)
    {
        Id = id;
        Name = name;
        Surname = surname;
        ReaderCardNumber = readerCardNumber;
        Books = new List<BookModel>();
    }

    public ReaderModel(int id, string name, string surname, string readerCardNumber, List<BookModel> books)
    {
        Id = id;
        Name = name;
        Surname = surname;
        ReaderCardNumber = readerCardNumber;
        Books = books;
    }
}