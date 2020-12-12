using System.Data;
using System.Data.SqlClient;

namespace GameHub.DAL.Implement
{
    public class BaseRepository
    {
        protected IDbConnection connection;

        public BaseRepository()
        {
            //connection = new SqlConnection(@"workstation id=gamedb2020.mssql.somee.com;packet size=4096;user id=HoangCG3_SQLLogin_1;pwd=eyltnsuamd;data source=gamedb2020.mssql.somee.com;persist security info=False;initial catalog=gamedb2020");
            connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=GameHubDb;Integrated Security=True");
        }
    }
}
