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
            _dbChecker.CheckDbString(_dbInstruction);
        }

        public string Execute()
        {
            var openMessage = _dbConnection.OpenConnection();
            var closeMessage = _dbConnection.CloseConnection();

            return $"{openMessage}\n Executing the command! \n{closeMessage}";
        }
    }
}
