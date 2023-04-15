using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Programs
{
    public class TypesOfInheritance
    {
        public void Message()
        {
            Console.WriteLine("Hello Everyone");
        }
    }
    public class Stationary : TypesOfInheritance
    {
        public void NoteBook()
        {
            Console.WriteLine("20 varieties of Notebook");    //Single Level Inheritance

        }
    }


    // Multilevel inheritance
    public class Pen : Stationary
    {
        public void BluePen()
        {
            Console.WriteLine("Diffrent colors of Pens");
        }
    }


    //Hierarchical inheritance
    public class CraftPaper : TypesOfInheritance
    {
        public void VerticleCraftPaper()
        {
            Console.WriteLine("Different Shapes of Craft Paper");
        }

    }
}

    

