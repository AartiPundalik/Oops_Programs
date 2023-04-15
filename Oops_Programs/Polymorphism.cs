using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Programs
{
    public class Polymorphism
    {
        public void FlowerSmells()
        {
            Console.WriteLine("Flowers Smells");
        }
    }

    class Lily : Polymorphism
    {
        public void FlowerSmells()
        {
            Console.WriteLine("Lily Smells So Nostalgic");
        }
    }

    class Jasmine : Polymorphism
    {
        public void FlowerSmells()
        {
            Console.WriteLine("Jasmine Smells so Refreshing");
        }
    }


    // Types Of Polymorphism

    public class IntergerNumber                     // Method Overloading
    {

        public void TotalSum(int a, int b)
        {
            Console.WriteLine("The sum of numbers is " + (a + b));
        }

        public void totalSum(double a, double b)
        {
            Console.WriteLine("The sum of numbers is " + (a + b));
        }

    }


    public class Polygon                               // Method Overriding
    {

        public virtual void render()
        {
            Console.WriteLine("Rendering Polygon...");
        }
    }

    class Square : Polygon
    {

        public override void render()
        {
            Console.WriteLine("Rendering Square...");
        }
    }
}


    

