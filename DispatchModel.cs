using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    internal class DispatchModel
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public int DriverId { get; set; }
        public int TruckId { get; set; }
        public int StatusId { get; set; }

        public DispatchModel(int id, string origin, string destination, DateTime departureDate, int driverId, int truckId, int statusId) 
        {
            Id = id;
            Origin = origin;
            Destination = destination;
            DepartureDate = departureDate;
            DriverId = driverId;
            TruckId = truckId;
            StatusId = statusId;
        }
    }
}
