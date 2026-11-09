using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Dispatch
{
    internal class DispatchRepository
    {
        public DispatchRepository() { }

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
