using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Programs
{
        abstract class AbstractionCar
        {
            public abstract void CarModel();
            public void ModelNo()
            {
                Console.WriteLine("ModelNo is 202");
            }
        }

        class Creta : AbstractionCar
        {
            public override void CarModel()
            {
                Console.WriteLine("Creata ModelNo is: 459");
                Console.ReadLine();

            }
        }
    }

