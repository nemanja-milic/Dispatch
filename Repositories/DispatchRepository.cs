using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dispatch.Enums;
using Dispatch.Models;
using Microsoft.Data.SqlClient;

namespace Dispatch.Repositories
{
    internal class DispatchRepository
    {
        public DispatchRepository() { }

        public async Task<List<DisplayDispatchModel>> GetAllDispatch()
        {
            DatabaseConnection DBconnection = new DatabaseConnection();
            List<DisplayDispatchModel> dispatchs = new List<DisplayDispatchModel>();


            await DBconnection.Connect();

            await using SqlCommand command =
                new SqlCommand("SELECT Dispatch.Id as DispatchId , Origin, Destination, DepartureDate, Driver.FirstName as DriverName, Driver.LicenseNumber as DriverLicenseNumber, Vehicle.RegistrationNumber as VehicleRegistrationNumber, Vehicle.Make, Driver_Status.StatusName, Driver_Status.Id as DriverStatusId \r\nfrom Dispatch\r\nJoin Driver On Dispatch.DriverId = Driver.Id\r\nJoin Vehicle On Vehicle.Id = Dispatch.TruckId \r\nJoin Driver_Status On Dispatch.StatusId = Driver_Status.Id",
                DBconnection.SQLConnection);

            await using SqlDataReader reader =
               await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                int driverStatusId = reader.GetInt32(reader.GetOrdinal("DriverStatusId"));
                string driverStatusName = reader.GetString(reader.GetOrdinal("StatusName"));
                DisplayDispatchModel dispatch = new DisplayDispatchModel
                    (
                        reader.GetInt32(reader.GetOrdinal("DispatchId")),
                        reader.GetString(reader.GetOrdinal("Origin")),
                        reader.GetString(reader.GetOrdinal("Destination")),
                        reader.GetDateTime(reader.GetOrdinal("DepartureDate")),
                        reader.GetString(reader.GetOrdinal("DriverName")),
                        reader.GetString(reader.GetOrdinal("DriverLicenseNumber")),
                        reader.GetString(reader.GetOrdinal("VehicleRegistrationNumber")),
                        reader.GetString(reader.GetOrdinal("Make")),
                        new DispatchStatus(driverStatusId, driverStatusName)
                    );
                dispatchs.Add(dispatch);
            }
            return dispatchs;
        }

        public async Task Insert(DispatchModel dispatchModel)
        {

            DatabaseConnection DBconnection = new DatabaseConnection();

            await DBconnection.Connect();

            await using SqlCommand command =
                new SqlCommand("INSERT INTO Dispatch " +
                "(Origin, Destination, DepartureDate, DriverId, TruckId, StatusId) " +
                "Values(@Origin, @Destination ,@DepartureDate, @DriverId, @TruckId, @StatusId);", 
                DBconnection.SQLConnection);

            command.Parameters.AddWithValue("@Origin", dispatchModel.Origin);
            command.Parameters.AddWithValue("@Destination", dispatchModel.Destination);
            command.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = dispatchModel.DepartureDate;
            command.Parameters.AddWithValue("@DriverId", dispatchModel.DriverId);
            command.Parameters.AddWithValue("@TruckId", dispatchModel.TruckId);
            command.Parameters.AddWithValue("@StatusId", dispatchModel.StatusId);

            int rowsAffected = await command.ExecuteNonQueryAsync();

            if (rowsAffected == 1)
            {
                Console.WriteLine("Dispatch added successfully!");
            }
        }

        public async Task<List<DispatchStatus>> FetchDispatchStatuses()
        {
            List<DispatchStatus> dispatchStatuses = new List<DispatchStatus>();
            DatabaseConnection DBconnection = new DatabaseConnection();

            await DBconnection.Connect();

            await using SqlCommand command =
                new SqlCommand("SELECT Id, Name FROM Dispatch_Status", DBconnection.SQLConnection);

            await using SqlDataReader reader =
                await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                DispatchStatus driverStatus = new DispatchStatus
                (
                    reader.GetInt32(reader.GetOrdinal("Id")),
                    reader.GetString(reader.GetOrdinal("Name"))
                );

                dispatchStatuses.Add(driverStatus);
            }

            return dispatchStatuses;
        }

    }
}
