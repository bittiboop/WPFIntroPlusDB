using System.Data.SqlClient;
using Dapper;
using DatavbaseService.DBCommands;

namespace DatavbaseService.DBProvider;

public class DatabaseProvider
{
    public string ConnectionString { get; set; }
    public DatabaseProvider(string connectionString)
    {
        ConnectionString = connectionString;
    }
    public void CreateDatabase()
    {
        using var connection = new SqlConnection(ConnectionString);
        connection.Open();
        var dbName = "Library";
        connection.ExecuteAsync(DBCommands.CreateDbCommandWithNotExists(dbName));
    }
}