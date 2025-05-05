using System.Data.SqlClient;

namespace DatavbaseService.DBCommands;

public class DbCommands
{
    public static string CreateDbCommandWithNotExists(string dbName)
    {
        return $"CREATE DATABASE IF NOT EXISTS {dbName}";
    }
    public static string CreateAuthorsTable()
    {
        return @"
            CREATE TABLE Authors (
                AuthorID INT PRIMARY KEY IDENTITY(1,1),
                Name NVARCHAR(100) NOT NULL,
                Surname NVARCHAR(100) NOT NULL,
                Country NVARCHAR(100) NULL
            )";
    }
    
    public static string CreateBooksTable()
    {
        return @"
            CREATE TABLE Books (
                Id INT PRIMARY KEY IDENTITY(1,1),
                Title NVARCHAR(255) NOT NULL
            )";
    }
    
    public static string CreateLibrariesTable()
    {
        return @"
            CREATE TABLE Libraries (
                Id INT PRIMARY KEY IDENTITY(1,1),
                Name NVARCHAR(255) NOT NULL
            )";
    }
    
    public static string CreateReadersTable()
    {
        return @"
            CREATE TABLE Readers (
                Id INT PRIMARY KEY IDENTITY(1,1),
                Name NVARCHAR(100) NOT NULL,
                Surname NVARCHAR(100) NOT NULL,
                ReaderCardNumber NVARCHAR(50) NOT NULL UNIQUE
            )";
    }
    
    public static string CreateAuthorBooksTable()
    {
        return @"
            CREATE TABLE AuthorBooks (
                AuthorID INT NOT NULL,
                BookId INT NOT NULL,
                PRIMARY KEY (AuthorID, BookId),
                FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID) ON DELETE CASCADE,
                FOREIGN KEY (BookId) REFERENCES Books(Id) ON DELETE CASCADE
            )";
    }
    
    public static string CreateAuthorLibrariesTable()
    {
        return @"
            CREATE TABLE AuthorLibraries (
                AuthorID INT NOT NULL,
                LibraryId INT NOT NULL,
                PRIMARY KEY (AuthorID, LibraryId),
                FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID) ON DELETE CASCADE,
                FOREIGN KEY (LibraryId) REFERENCES Libraries(Id) ON DELETE CASCADE
            )";
    }
    
    public static string CreateBookLibrariesTable()
    {
        return @"
            CREATE TABLE BookLibraries (
                BookId INT NOT NULL,
                LibraryId INT NOT NULL,
                PRIMARY KEY (BookId, LibraryId),
                FOREIGN KEY (BookId) REFERENCES Books(Id) ON DELETE CASCADE,
                FOREIGN KEY (LibraryId) REFERENCES Libraries(Id) ON DELETE CASCADE
            )";
    }
    
    public static string CreateRelatedBooksTable()
    {
        return @"
            CREATE TABLE RelatedBooks (
                BookId INT NOT NULL,
                RelatedBookId INT NOT NULL,
                PRIMARY KEY (BookId, RelatedBookId),
                FOREIGN KEY (BookId) REFERENCES Books(Id) ON DELETE CASCADE,
                FOREIGN KEY (RelatedBookId) REFERENCES Books(Id) ON DELETE CASCADE
            )";
    }
    
    public static string CreateReaderLibrariesTable()
    {
        return @"
            CREATE TABLE ReaderLibraries (
                ReaderId INT NOT NULL,
                LibraryId INT NOT NULL,
                PRIMARY KEY (ReaderId, LibraryId),
                FOREIGN KEY (ReaderId) REFERENCES Readers(Id) ON DELETE CASCADE,
                FOREIGN KEY (LibraryId) REFERENCES Libraries(Id) ON DELETE CASCADE
            )";
    }
}