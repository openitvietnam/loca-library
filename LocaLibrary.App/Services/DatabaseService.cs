using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Windows.Forms;

namespace LocaLibrary.App.Services
{
    internal class DatabaseService
    {
        private static readonly string CONNECTION_STRING;

        static DatabaseService()
        {
            ConnectionStringSettingsCollection connectionStrings = null;
            try
            {
                connectionStrings = ConfigurationManager.ConnectionStrings;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Environment.Exit(1);
            }
            if (connectionStrings == null || connectionStrings.Count == 0)
            {
                MessageBox.Show("No connection string", "Error");
                Environment.Exit(2);
            }
            CONNECTION_STRING = connectionStrings[0].ConnectionString;
        }

        public static void Check(ref string error)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
        }

        public static SqlCommand CreateCommand(string sql, CommandType type)
        {
            return new SqlCommand(sql)
            {
                CommandType = type
            };
        }

        public static void Execute(SqlCommand command, ref string error)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
        }

        public static object GetValue(SqlCommand command, ref string error)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                command.Connection = connection;
                try
                {
                    connection.Open();
                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return null;
                }
            }
        }

        public static SqlDataReader GetDataReader(SqlCommand command, ref string error)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                command.Connection = connection;
                try
                {
                    connection.Open();
                    return command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return null;
                }
            }
        }

        public static DataTable GetDataTable(SqlCommand command, ref string error)
        {
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                command.Connection = connection; // no need to Open() connection
                using (var adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message;
                    }
                }
            }
            return dataTable;
        }
    }
}
