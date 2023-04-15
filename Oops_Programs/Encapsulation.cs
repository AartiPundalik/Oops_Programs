using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Programs
{
    public class Encapsulation
    {
            public String PersonName;
            public int PersonAge;

            public String Name
            {
                get { return PersonName; }

                set { PersonName = value; }
            }

            public int Age
            {
                get { return PersonAge; }

                set { PersonAge = value; }
            }
        }
    }

