using Core.Entity;
using DatavbaseService.Abstractions;

namespace DatavbaseService.Models;

public class ReaderModel : IModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? ReaderCardNumber { get; set; }
    public List<LibraryModel> Library { get; set; }

    public ReaderModel()
    {
        Library = new List<LibraryModel>();
    }
    
    public ReaderModel(int id, string name, string surname, string readerCardNumber)
    {
        Id = id;
        Name = name;
        Surname = surname;
        ReaderCardNumber = readerCardNumber;
    }

    public ReaderModel(int id, string name, string surname, string readerCardNumber, List<LibraryModel> libraries)
    {
        Id = id;
        Name = name;
        Surname = surname;
        ReaderCardNumber = readerCardNumber;
        Library = libraries;
    }
}