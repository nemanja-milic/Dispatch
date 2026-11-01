using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    internal class CreateDriverModel :DriverBase
    {
        public CreateDriverModel(string name, string lastName, string LicenseNumber, int statusId)
                :base(name, lastName, LicenseNumber, statusId)
        {
            
        }
    }
}
