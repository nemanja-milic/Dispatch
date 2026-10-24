using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    internal class DriverModel
    {
        public int Id { get; private set; }

        public string Name { get; set; }
        
        public string LastName { get; set; }
        public string LicenseNumber { get; set; }
        public DriverModel(int id, string name, string lastName, string license)
        {
            Id = id;
            Name = name;
            LicenseNumber = license;
        }
    }
}
