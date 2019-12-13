namespace DbConnection
{
    public class PostgresDbConnection : DbConnection
    {
        public PostgresDbConnection(string connectionString)
            : base(connectionString)
        {            
        }

        public override string OpenConnection()
        {
            return "Postgres is opening a new connection...";
        }

        public override string CloseConnection()
        {
            return "Postgres is closing the connection...";
        }
    }
}
