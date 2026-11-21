using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dispatch.Enums;

namespace Dispatch.Models
{
    public class DisplayDispatchModel : DispatchModelBase
    {
        public string DriverName { get; set; }
        public string DriverRegistrationNumber { get; set; }
        public string TruckRegistrationNumber { get; set; }
        public string TruckMake {  get; set; }

        public DispatchStatus DispatchStatus { get; set; }

        public DisplayDispatchModel(int id, string origin, string destination, DateTime departureDate, string driverName, string driverRegistrationNumber, string truckRegistrationNumber, string truckMake, DispatchStatus dispatchStatus)
            :base(id, origin, destination, departureDate) 
        {
            DriverName = driverName;
            DriverRegistrationNumber = driverRegistrationNumber;
            TruckRegistrationNumber = truckRegistrationNumber;
            TruckMake = truckMake;
            DispatchStatus = dispatchStatus;
        }
    }
}
