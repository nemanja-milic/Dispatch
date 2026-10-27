using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    internal abstract class DriverBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string LicenseNumber { get; set; }
        public DriverBase(string name, string lastName, string license)
        {
            FirstName = name;
            LastName = lastName;
            LicenseNumber = license;
        }
    }
}
