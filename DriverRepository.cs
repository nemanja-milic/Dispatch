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
            return await FetchDriversFromDB(
                "select Driver.Id, FirstName, LastName, LicenseNumber, Driver_Status.StatusName, Driver_Status.Id as DriverStatusId\r\nFrom Driver\r\nInner Join Driver_Status On Driver.StatusId = Driver_Status.Id");
            
        }

        public async Task AddDriver(CreateDriverModel driver)
        {
            List<DriverModel> drivers = new List<DriverModel>();

            DatabaseConnection DBconnection = new DatabaseConnection();

            await DBconnection.Connect();

            await using SqlCommand command =
                new SqlCommand("insert into Driver(FirstName, LastName, LicenseNumber, StatusId) Values(@FirstName, @LastName, @LicenseNumber, @StatusId)", DBconnection.SQLConnection);

            command.Parameters.AddWithValue("@FirstName", driver.FirstName);    
            command.Parameters.AddWithValue("@LastName", driver.LastName);
            command.Parameters.AddWithValue("@LicenseNumber", driver.LicenseNumber);
            command.Parameters.AddWithValue("@StatusId", driver.StatusId);


            int rowsAffected = await command.ExecuteNonQueryAsync();

            if (rowsAffected == 1)
            {
                Console.WriteLine("Driver added successfully!");
            }

        }

        public async Task EditDriver(EditDriverModel driver)
        {
            DatabaseConnection DBconnection = new DatabaseConnection();

            await DBconnection.Connect();

            await using SqlCommand command =
                new SqlCommand("UPDATE Driver " +
                "SET FirstName = @FirstName, " +
                "LastName = @LastName, " +
                "LicenseNumber = @LicenseNumber, "+
                "StatusId = @StatusId " +
                "Where Id = @Id"
                , DBconnection.SQLConnection);

            command.Parameters.AddWithValue("@FirstName", driver.FirstName);
            command.Parameters.AddWithValue("@LastName", driver.LastName);
            command.Parameters.AddWithValue("@LicenseNumber", driver.LicenseNumber);
            command.Parameters.AddWithValue("@StatusId", driver.StatusId);
            command.Parameters.AddWithValue("@Id", driver.Id);



            int rowsAffected = await command.ExecuteNonQueryAsync();

            if (rowsAffected == 1)
            {
                Console.WriteLine("Driver edited successfully!");
            }
        }

        public async Task<List<DriverStatus>> FetchDriverStatus()
        {
            List<DriverStatus> driverStatuses = new List<DriverStatus>();
            DatabaseConnection DBconnection = new DatabaseConnection();

            await DBconnection.Connect();

            await using SqlCommand command =
                new SqlCommand("SELECT Id, StatusName FROM Driver_Status", DBconnection.SQLConnection);

            await using SqlDataReader reader =
                await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                DriverStatus driverStatus = new DriverStatus
                (
                    reader.GetInt32(reader.GetOrdinal("Id")),
                    reader.GetString(reader.GetOrdinal("StatusName"))
                );

                driverStatuses.Add(driverStatus);
            }

            return driverStatuses;
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
                    reader.GetString(reader.GetOrdinal("LicenseNumber")),
                    reader.GetInt32(reader.GetOrdinal("DriverStatusId")),
                    reader.GetString(reader.GetOrdinal("StatusName"))
                );

                drivers.Add(driver);
            }
            return drivers;
        }

    }
}
