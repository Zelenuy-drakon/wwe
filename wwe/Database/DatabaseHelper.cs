using MySql.Data.MySqlClient;
using System;          
using System.Configuration;
using System.Data;
using System.Net.Sockets;
using System.Threading.Tasks;

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

        public int  ExecuteNonQuery(string query, MySqlParameter[]? parameters)
        {
            return ExecuteNonQuery(query, parameters);
        }

        public DataTable ExecuteQuery(string query, MySqlParameter parameter)
        {
            return ExecuteQueryWithRetry(query, new[] { parameter });
        }
        public DataTable ExecuteQuery(string query, MySqlParameter[]? parameters = null)
        {
            return ExecuteQueryWithRetry(query, parameters);
        }
        public async Task<DataTable> ExecuteQueryAsync(string query, MySqlParameter[]? parameters = null)
        {
            return await ExecuteQueryWithRetryAsync(query, parameters);
        }

        public async Task<int> ExecuteNonQueryAsync(string query, MySqlParameter[]? parameters = null)
        {
            using var conn = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(query, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            await conn.OpenAsync();
            return await cmd.ExecuteNonQueryAsync();
        }

        public int ExecuteNonQuery(string query, MySqlParameter parameter)
        {
            return ExecuteNonQuery(query, new[] { parameter });
        }

        
        public async Task<object?> ExecuteScalarAsync(string query, MySqlParameter[]? parameters = null)
        {
            using var conn = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(query, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            await conn.OpenAsync();
            cmd.Prepare();
            return await cmd.ExecuteScalarAsync();
        }
        private DataTable ExecuteQueryInternal(string query, MySqlParameter[]? parameters)
        {
            using var conn = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(query, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            using var da = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ExecuteQueryWithRetry(string query, MySqlParameter[]? parameters = null, int retryCount = 3)
        {
            for (int i = 0; i < retryCount; i++)
            {
                try
                {
                    ExecuteQueryInternal(query, parameters);
                }
                catch (MySqlException ex)
                {
                    if ((ex.Number == 0 && ex.Message.Contains("Fatal error")) || ex.Message.Contains("gone away") || ex.InnerException is SocketException)
                    {
                        System.Diagnostics.Debug.WriteLine($"Попытка {i + 1}: {ex.Message}");
                        System.Threading.Thread.Sleep(1000 * (i + 1));
                        continue;
                    }
                    throw;
                }
            }
            return new DataTable();
        }
        public async Task<DataTable> ExecuteQueryWithRetryAsync(string query, MySqlParameter[]? parameters = null, int retryCount = 3)
        {
            for (int i = 0; i < retryCount; i++)
            {
                try
                {
                    using var conn = new MySqlConnection(connectionString);
                    using var cmd = new MySqlCommand(query, conn);
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    await conn.OpenAsync();
                    using var reader = await cmd.ExecuteReaderAsync();
                    var dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    if ((ex.Number == 0 && ex.Message.Contains("Fatal error")) || ex.Message.Contains("gone away") || ex.InnerException is SocketException)
                    {
                        await Task.Delay(1000 * (i + 1)); 
                        continue;
                    }
                    throw;
                }
            }
            return new DataTable();
        }
        public async Task<object?> ExecuteScalarAsync(string query, MySqlParameter parameter)
        {
            return await ExecuteScalarAsync(query, new[] { parameter });

        }
        public async Task<DataTable> ExecuteQueryAsync(string query, MySqlParameter parameter)
        {
            return await ExecuteQueryAsync(query, new[] { parameter });
        }
        public async Task<int> ExecuteNonQueryAsync(string query, MySqlParameter parameter)
        {
            return await ExecuteNonQueryAsync(query, new[] { parameter });
        }
    }

}