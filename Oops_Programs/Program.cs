using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace Oops_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Types Of Inheritance
            Stationary stationary = new Stationary();
            stationary.NoteBook();
            Pen pen = new Pen();
            pen.BluePen();
            CraftPaper craftpaper = new CraftPaper();
            craftpaper.VerticleCraftPaper();
            WritingMaterial material = new Envelops();
            material.Classmate();

            // Class And Object
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1.insert(65, "Aarti", 800000f);
            e2.insert(66, "Sangita", 400000f);
            e1.display();
            e2.display();
            Console.ReadLine();


        }
    }

}






    



    
    
    


    

    
    
    

