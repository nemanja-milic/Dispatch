using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Dispatch
{
    internal class DriverRepository
    {
        public async Task<List<DriverModel>> GetAll()
        {
            return await FetchDriversFromDB("Select Id, FirstName, LastName, LicenseNumber from driver");
            
        }

        public async Task AddDriver(CreateDriverModel driver)
        {
            List<DriverModel> drivers = new List<DriverModel>();

            DatabaseConnection DBconnection = new DatabaseConnection();

            await DBconnection.Connect();

            await using SqlCommand command =
                new SqlCommand("insert into Driver(FirstName, LastName, LicenseNumber) Values(@FirstName, @LastName, @LicenseNumber)", DBconnection.SQLConnection);

            command.Parameters.AddWithValue("@FirstName", driver.FirstName);    
            command.Parameters.AddWithValue("@LastName", driver.LastName);
            command.Parameters.AddWithValue("@LicenseNumber", driver.LicenseNumber);


            int rowsAffected = await command.ExecuteNonQueryAsync();

            if (rowsAffected == 1)
            {
                Console.WriteLine("Driver added successfully!");
            }

        }

        private async Task<List<DriverModel>> FetchDriversFromDB(string sqlCode)
        {
            List<DriverModel> drivers = new List<DriverModel>();

            DatabaseConnection DBconnection = new DatabaseConnection();

            await DBconnection.Connect();

            await using SqlCommand command =
                new SqlCommand(sqlCode, DBconnection.SQLConnection);

            await using SqlDataReader reader =
                await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                DriverModel driver = new DriverModel
                (
                    reader.GetInt32(reader.GetOrdinal("Id")),
                    reader.GetString(reader.GetOrdinal("FirstName")),
                    reader.GetString(reader.GetOrdinal("LastName")),
                    reader.GetString(reader.GetOrdinal("LicenseNumber"))
                );

                drivers.Add(driver);
            }
            return drivers;
        }

    }
}
