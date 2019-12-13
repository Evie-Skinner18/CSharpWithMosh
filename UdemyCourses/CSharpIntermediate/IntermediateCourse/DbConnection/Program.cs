using System;

namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the DB!");

            var postgresConnection = new PostgresDbConnection(null);
            Console.WriteLine($"{postgresConnection.OpenConnection()}");
            Console.WriteLine($"{postgresConnection.CloseConnection()}");

            var oracleConnection = new OracleDbConnection("");
            Console.WriteLine($"{oracleConnection.OpenConnection()}");
            Console.WriteLine($"{oracleConnection.CloseConnection()}");
        }
    }
}
