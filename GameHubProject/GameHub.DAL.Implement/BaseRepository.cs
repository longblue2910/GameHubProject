using System.Data;
using System.Data.SqlClient;

namespace GameHub.DAL.Implement
{
    public class BaseRepository
    {
        protected IDbConnection connection;

        public BaseRepository()
        {
            connection = new SqlConnection(@"Data Source=admin\sqlexpress;Initial Catalog=GameHubDb;Integrated Security=True");
        }
    }
}
