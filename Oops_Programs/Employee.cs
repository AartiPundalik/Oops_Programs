using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Programs
{
    public class Employee
    {
            public int id;
            public String name;
            public float salary;
            public void insert(int i, String n, float s)
            {
                id = i;
                name = n;
                salary = s;
            }
            public void display()
            {
                Console.WriteLine(id + " " + name + " " + salary);
            }
        }
    }

