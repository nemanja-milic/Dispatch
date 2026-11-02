using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    public class TruckModel
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }
        public int Year { get; set; }
        public int CurrentMileageMiles { get; set; }
        public bool IsAvailable { get; set; }
        public TruckModel(int id, string registrationNumber, string make, string model, int year, int currentMileageMiles, bool isAvailable) 
        {
            Id = id;
            RegistrationNumber = registrationNumber;
            Make = make;
            Model = model;
            Year = year;
            CurrentMileageMiles = currentMileageMiles;
            IsAvailable = isAvailable;
        }

    }
}
