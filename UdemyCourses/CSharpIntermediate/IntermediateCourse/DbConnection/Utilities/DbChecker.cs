using System;

namespace DbConnection.Utilities
{
    public class DbChecker
    {
        // can I use generics to avoid this repetition?
        public void CheckConnectionString(string connectionString)
        {
            var isValid = string.IsNullOrWhiteSpace(connectionString) ? false : true;

            if (isValid == false)
            {
                throw new InvalidOperationException("Sorry but you can't make a DB connection with no connection stwing!");
            }
        }

        public void CheckDbConnection(DbConnection dbConnection)
        {
            var isValid = dbConnection == null ? false : true;

            if (isValid == false)
            {
                throw new InvalidOperationException("Sorry but you can't make a DB command with no DB connection!");
            }
        }
    }
}
