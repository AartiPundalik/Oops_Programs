using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Programs
{
    public class VehicleInheritance
    {

            public string brand = "Mahindra Truck";
            public void EngineNo()
            {
                Console.WriteLine(" EngineNo is 2B11");
            }
        }

        class Truck : VehicleInheritance
        {
            public string modelName = "Kia Bongo";

        }

    }

