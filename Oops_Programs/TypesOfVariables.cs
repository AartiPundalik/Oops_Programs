using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Programs
{
    public class TypesOfVariables
    {
        // Local Variable
        public void PersonAge()
        {
            int age = 0;

            age = age + 22;
            Console.WriteLine("Person age is : " + age);
        }
    }
    // Instance Variable

    class Person
    {
        // Instance variables
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Hello()
        {
            Console.WriteLine("Hello, my name is {0} and I am {1} years old.", name, age);
        }

        // Static Variable
        public class StaticExample
        {
            static int staticVariable = 0;

            public static void StaticVariable()
            {
                staticVariable++;
                Console.WriteLine("Static variable value: " + staticVariable);
            }
        }

    }
}
    

