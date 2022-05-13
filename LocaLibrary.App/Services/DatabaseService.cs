using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace LocaLibrary.App.Services
{
    internal class DatabaseService
    {
        private static readonly string CONNECTION_STRING =
            @"Data Source = localhost\SQLEXPRESS;
            Initial Catalog = LocaLibrary;
            User ID = LocaLibrary;
            Password = 123456";

        public static void Check()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
            }
        }

        public static SqlCommand CreateCommand(string sql, CommandType type)
        {
            return new SqlCommand(sql)
            {
                CommandType = type
            };
        }

        public static void Execute(SqlCommand command)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static object GetValue(SqlCommand command)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                command.Connection = connection;
                connection.Open();
                return command.ExecuteScalar();
            }
        }

        public static SqlDataReader GetDataReader(SqlCommand command)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                command.Connection = connection;
                connection.Open();
                return command.ExecuteReader();
            }
        }

        public static DataTable GetDataTable(SqlCommand command)
        {
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                command.Connection = connection; // no need to Open() connection
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
}
