using DbConnection.Utilities;

namespace DbConnection
{
    public class OracleDbConnection : DbConnection
    {
        public OracleDbConnection(string connectionString, DbChecker dbChecker)
            : base(connectionString, dbChecker)
        {
        }

        public override string OpenConnection()
        {
            return "opening Oracle DB Connection";
        }

        public override string CloseConnection()
        {
            return "closing Oracle DB Connection";
        }
    }
}
