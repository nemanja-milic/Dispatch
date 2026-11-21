using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch.Models
{
    public class DriverModel : DriverBaseModel
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
