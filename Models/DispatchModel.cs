using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch.Models
{
    public class DispatchModel :DispatchModelBase
    {
        public int DriverId { get; set; }
        public int TruckId { get; set; }
        public int StatusId { get; set; }

        public DispatchModel(int id, string origin, string destination, DateTime departureDate, int driverId, int truckId, int statusId) 
            :base(id, origin, destination, departureDate)
        {
            DriverId = driverId;
            TruckId = truckId;
            StatusId = statusId;
        }
    }
}
