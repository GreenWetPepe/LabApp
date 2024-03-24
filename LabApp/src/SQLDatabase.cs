using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LabApp
{
    public delegate void StatusHandler(string message);
    public delegate void QueryHandler(MySqlDataReader reader);
    public static class SQLDatabase
    {
        private static MySqlConnection _connection;
        private static StatusHandler _statusHandler;
        private static QueryHandler _queryHandler;

        public static void SetConnection(string connection) => _connection = new MySqlConnection(connection);
        public static void SetStatusHandler(StatusHandler statusHandler) => _statusHandler = statusHandler;
        public static void SetQueryHandler(QueryHandler queryHandler) =>_queryHandler = queryHandler;


        public static void ExecuteCommand(string command)
        {
            MySqlCommand commandDatabase = new MySqlCommand(command, _connection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                _connection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    _queryHandler.Invoke(reader);
                }

                _connection.Close();
            }
            catch (Exception ex)
            {
                _statusHandler.Invoke(ex.Message);
            }
            finally
            {
                _statusHandler.Invoke("Command completed");
            }
        }
    }
}
