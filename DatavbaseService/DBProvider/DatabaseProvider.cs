using System.Data.SqlClient;
using Dapper;
using DatavbaseService.DBCommands;

namespace DatavbaseService.DBProvider;



public class DatabaseProvider
{
    private string ConnectionString { get; set; }

    [Obsolete("Obsolete")]
    public void CreateDatabase()
    {
        try
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var dbName = "LibraryDB";
            connection.ExecuteAsync(DbCommands.CreateDbCommandWithNotExists(dbName));
        }
        catch (SqlException e)
        {
            throw new Exception(e.Message);
        }
        
    }
    
}