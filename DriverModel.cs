using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    public class DriverModel : DriverBase
    {
        public int Id { get; private set; }

        public string StatusName { get; private set; }

        public DriverModel(int id, string name, string lastName, string license, int statusId, string statusName)
            :base(name, lastName, license, statusId)
        {
            Id = id;
            StatusName = statusName;
        }
    }
}
