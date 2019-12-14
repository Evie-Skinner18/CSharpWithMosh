using System;
using DbConnection.Utilities;

namespace DbConnection
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        private DbChecker _dbChecker { get; set; }

        public DbConnection(string connectionString, DbChecker dbChecker)
        {
            _connectionString = connectionString;
            _dbChecker = dbChecker;
            _dbChecker.CheckDbString(_connectionString);
        }

        public abstract string OpenConnection();

        public abstract string CloseConnection();
    }
}
