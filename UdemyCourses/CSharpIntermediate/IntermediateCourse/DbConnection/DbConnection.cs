using System;

namespace DbConnection
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            _connectionString = connectionString;
            CheckConnectionString();
        }

        public void CheckConnectionString()
        {
            var isValid = string.IsNullOrWhiteSpace(_connectionString) ? false : true;

            if (isValid == false)
            {
                throw new InvalidOperationException("Sorry but you can't make a DB connection with no connection stwing!");
            }
        }

        public abstract string OpenConnection();

        public abstract string CloseConnection();
    }
}
