using System.Data.SqlClient;

namespace DatavbaseService.DBCommands;

public class DBCommands
{
    public static string CreateDbCommandWithNotExists(string dbName)
    {
        return $"CREATE DATABASE IF NOT EXISTS {dbName}";
    }
}