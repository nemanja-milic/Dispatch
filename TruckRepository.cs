using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Dispatch
{
    internal class TruckRepository
    {
        public TruckRepository() { }

        public async Task<List<TruckModel>> AllTrucks()
        {
            List<TruckModel> trucks = new List<TruckModel>();

            DatabaseConnection DBconnection = new DatabaseConnection();

            await DBconnection.Connect();

            await using SqlCommand command =
                new SqlCommand("select Id, RegistrationNumber, Make, Model, Year, CurrentMileageMiles, IsAvailable from Vehicle;", DBconnection.SQLConnection);

            await using SqlDataReader reader =
                await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                TruckModel truck = new TruckModel
                (
                    reader.GetInt32(reader.GetOrdinal("Id")),
                    reader.GetString(reader.GetOrdinal("RegistrationNumber")),
                    reader.GetString(reader.GetOrdinal("Make")),
                    reader.GetString(reader.GetOrdinal("Model")),
                    reader.GetInt16(reader.GetOrdinal("Year")),
                    reader.GetInt32(reader.GetOrdinal("CurrentMileageMiles")),
                    reader.GetBoolean(reader.GetOrdinal("IsAvailable"))

                );
                trucks.Add(truck);
            }
            return trucks;
        }

        public async Task<int> EditTruck(TruckModel truck)
        {
            DatabaseConnection DBconnection = new DatabaseConnection();

            await DBconnection.Connect();

            await using SqlCommand command =
                new SqlCommand("UPDATE Vehicle " +
                "Set RegistrationNumber = @RegistrationNumber, " +
                "IsAvailable = @IsAvailable, " +
                "CurrentMileageMiles = @CurrentMileageMiles " +
                "Where Id = @Id;"
                , DBconnection.SQLConnection);

            command.Parameters.AddWithValue("@RegistrationNumber", truck.RegistrationNumber);
            command.Parameters.AddWithValue("@IsAvailable", truck.IsAvailable);
            command.Parameters.AddWithValue("@CurrentMileageMiles", truck.CurrentMileageMiles);
            command.Parameters.AddWithValue("@Id", truck.Id);



            int rowsAffected = await command.ExecuteNonQueryAsync();

            if (rowsAffected == 1)
            {
                Console.WriteLine("Truck edited successfully!");
                return 1;
            }
            return 0;
        }

        public async Task<int> AddTruck(TruckModel truck)
        {
            DatabaseConnection DBconnection = new DatabaseConnection();

            await DBconnection.Connect();

            await using SqlCommand command =
                new SqlCommand("" +
                "INSERT INTO Vehicle" +
                "(RegistrationNumber, Make, Model, Year, CurrentMileageMiles, IsAvailable)" +
                "Values(@RegistrationNumber, @Make, @Model, @Year, @CurrentMileageMiles, @IsAvailable);"
                , DBconnection.SQLConnection);

            command.Parameters.AddWithValue("@RegistrationNumber", truck.RegistrationNumber);
            command.Parameters.AddWithValue("@Make", truck.Make);
            command.Parameters.AddWithValue("@Model", truck.Model);
            command.Parameters.AddWithValue("@Year", truck.Year);
            command.Parameters.AddWithValue("@CurrentMileageMiles", truck.CurrentMileageMiles);
            command.Parameters.AddWithValue("@IsAvailable", truck.IsAvailable);



            int rowsAffected = await command.ExecuteNonQueryAsync();

            if (rowsAffected == 1)
            {
                Console.WriteLine("Truck edited successfully!");
                return 1;
            }
            return 0;
        }
    }
}
