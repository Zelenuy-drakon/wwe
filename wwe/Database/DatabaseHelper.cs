using MySql.Data.MySqlClient;
using System;          
using System.Configuration;
using System.Data;
using System.Net.Sockets;

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
            return ExecuteQueryWithRetry(query, new[] { parameter });
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
        public DataTable ExecuteQueryWithRetry(string query, MySqlParameter[]? parameters = null, int retryCount = 3)
        {
            for (int i = 0; i < retryCount; i++)
            {
                try
                {
                    return ExecuteQuery(query, parameters);
                }
                catch (MySqlException ex)
                {
                    
                    if ((ex.Number == 0 && ex.Message.Contains("Fatal error")) || ex.Message.Contains("gone away") || ex.InnerException is SocketException)
                    {
                        Console.WriteLine($"Пиздец с подключением, переподключаюсь, попытка {i + 1} из {retryCount}. Ошибка: {ex.Message}");
                        System.Threading.Thread.Sleep(1000 * (i + 1)); 
                        continue;
                    }
                    throw; 
                }
            }
            return new DataTable();
        }
        public object? ExecuteScalar(string query, MySqlParameter parameter)
        {
            return ExecuteScalar(query, new[] { parameter });

        }
    }
}