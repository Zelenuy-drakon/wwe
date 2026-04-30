using System;          
using System.Data;
using Microsoft.Data.SqlClient;
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

        public DataTable ExecuteQuery(string query, SqlParameter[]? parameters = null)
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ExecuteQuery(string query, SqlParameter parameter)
        {
            return ExecuteQuery(query, new[] { parameter });
        }

        public int ExecuteNonQuery(string query, SqlParameter[]? parameters = null)
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public int ExecuteNonQuery(string query, SqlParameter parameter)
        {
            return ExecuteNonQuery(query, new[] { parameter });
        }

        public object? ExecuteScalar(string query, SqlParameter[]? parameters = null)
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            conn.Open();
            return cmd.ExecuteScalar();
        }

        public object? ExecuteScalar(string query, SqlParameter parameter)
        {
            return ExecuteScalar(query, new[] { parameter });
        }
    }
}