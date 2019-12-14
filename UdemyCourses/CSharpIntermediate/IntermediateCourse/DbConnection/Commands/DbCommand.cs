using DbConnection.Utilities;

namespace DbConnection.Commands
{
    public class DbCommand
    {
        private DbConnection _dbConnection { get; set; }
        private string _dbInstruction { get; set; }
        private DbChecker _dbChecker { get; set; }

        public DbCommand(DbConnection dbConnection, string dbInstruction, DbChecker dbChecker)
        {
            _dbConnection = dbConnection;
            _dbInstruction = dbInstruction;
            _dbChecker = dbChecker;
            _dbChecker.CheckDbConnection(_dbConnection);
        }


    }


}
