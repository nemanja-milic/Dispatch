using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    internal class DriverModel : DriverBase
    {
        public int Id { get; private set; }
        public DriverModel(int id, string name, string lastName, string license)
            :base(name, lastName, license)
        {
            Id = id;
        }
    }
}
