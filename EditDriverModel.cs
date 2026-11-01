using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    class EditDriverModel : DriverBase
    {
        public int Id { get; private set; }
        public EditDriverModel(int id, string name, string lastName, string LicenseNumber, int statusId)
                : base(name, lastName, LicenseNumber, statusId)
        {
            Id = id;
        }
    }
}
