using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    internal class DriverStatus
    {
        public int Id {  get; private set; }
        public string Name { get; private set; }
        public DriverStatus(int id, string name) 
        {
            Id = id;
            Name = name;
        }
    }
}
