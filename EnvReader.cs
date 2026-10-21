using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    internal class EnvReader
    {
        public static string Read(string property)
        {
            if(!File.Exists(".env"))
            {
                Console.WriteLine("Unable to find .env file");
                return "";
            }
            string[] lines = File.ReadAllLines(".env");

            foreach(string line in lines)
            {
                if(line.Contains(property))
                {
                    string[] parts = line.Split('=', 2);
                    if (parts[0] == property)
                    {
                        return parts[1];
                    }
                }
            }

            Console.WriteLine("Didn`t find a property");
            return "";
        }
    }
}
