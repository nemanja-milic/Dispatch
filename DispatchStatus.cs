using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    internal class DispatchStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DispatchStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
