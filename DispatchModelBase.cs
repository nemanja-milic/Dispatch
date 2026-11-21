using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    public abstract class DispatchModelBase
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }

        public DispatchModelBase(int id, string origin, string destination, DateTime departureDate)
        {
            Id = id;
            Origin = origin;
            Destination = destination;
            DepartureDate = departureDate;
        }
    }
}
