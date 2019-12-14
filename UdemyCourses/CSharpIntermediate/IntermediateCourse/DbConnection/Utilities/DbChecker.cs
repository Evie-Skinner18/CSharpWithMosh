using System;

namespace DbConnection.Utilities
{
    public class DbChecker
    {
        // can I use generics to avoid this repetition?
        public void CheckDbString(string dbString)
        {
            var isValid = string.IsNullOrWhiteSpace(dbString) ? false : true;

            if (isValid == false)
            {
                throw new InvalidOperationException("Sorry but you can't do any DB stuff with no stwing!");
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

        //public void CheckDbInstruction
    }
}
