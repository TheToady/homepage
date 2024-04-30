using Dapper;
namespace homepage_backend.Utils;
using System.Data;
using Npgsql;

public class DbHandler : IDbHandler
{
    // TODO: Setup foreign key
    private readonly IDbConnection _db;

    public DbHandler(IConfiguration configuration)
    {
        _db = new NpgsqlConnection(configuration.GetConnectionString("devBackup"));
    }

    //Request a query based on passed command and parameters
    public async Task<T?> GetAsync<T>(string command, object param)
    {
        return (await _db.QueryAsync<T>(command, param).ConfigureAwait(false)).FirstOrDefault();
    }
    
    //Update an entry based on passed command and parameters
    public async Task<bool> ExecuteAsync(string command, object param)
    {
        int result = await _db.ExecuteAsync(command, param);
        
        if (result > 0) return true;
        return false;
    }
}