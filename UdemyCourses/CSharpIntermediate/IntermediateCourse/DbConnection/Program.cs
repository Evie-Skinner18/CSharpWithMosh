using System;
using DbConnection.Commands;
using DbConnection.Utilities;

namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the DB!");

            var dbChecker = new DbChecker();

            var postgresConnection = new PostgresDbConnection("wickwickbickbick", dbChecker);
            var oracleConnection = new OracleDbConnection("HiyaBrenda", dbChecker);

            var dbCommand = new DbCommand(oracleConnection, "SELECT * FROM DibbyTable", dbChecker);
            Console.WriteLine(dbCommand.Execute());
        }
    }
}
