using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Dispatch
{
    internal class DatabaseConnection
    {
        public SqlConnection SQLConnection { get; private set; }
        public async Task Connect()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = EnvReader.Read("DBDataSource"),
                IntegratedSecurity = true,
                InitialCatalog = EnvReader.Read("DBName"),
                TrustServerCertificate = true
            };

            var connectionString = builder.ConnectionString;

            try
            {
                var connection = new SqlConnection(connectionString);
                
                await connection.OpenAsync();

                Console.WriteLine("SUCCESS! Connected to SQL Server.");

                SQLConnection = connection;
            }
            catch (SqlException e) 
            {
                Console.WriteLine($"SQL Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
