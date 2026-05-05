using System;          
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace OnlineStoreApp
{
    public class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper()
        {
            var connectionStringSettings = ConfigurationManager.ConnectionStrings["StoreDB"];
            if (connectionStringSettings == null)
            {
                throw new Exception("Строка подключения 'StoreDB' не найдена в App.config");
            }
            connectionString = connectionStringSettings.ConnectionString;
        }

        public string GetConnectionString() => connectionString;

        public DataTable ExecuteQuery(string query, MySqlParameter[]? parameters = null)
        {
            using var conn = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            using var da = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ExecuteQuery(string query, MySqlParameter parameter)
        {
            return ExecuteQuery(query, new[] { parameter });
        }

        public int ExecuteNonQuery(string query, MySqlParameter[]? parameters = null)
        {
            using var conn = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public int ExecuteNonQuery(string query, MySqlParameter parameter)
        {
            return ExecuteNonQuery(query, new[] { parameter });
        }

        public object? ExecuteScalar(string query, MySqlParameter[]? parameters = null)
        {
            using var conn = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            conn.Open();
            return cmd.ExecuteScalar();
        }

        public object? ExecuteScalar(string query, MySqlParameter parameter)
        {
            return ExecuteScalar(query, new[] { parameter });
        }
    }
}