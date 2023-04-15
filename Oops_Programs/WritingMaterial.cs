using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Programs
{
    public interface WritingMaterial
    {
        void Classmate();
    }
    public class Envelops : WritingMaterial
    {
        public void Classmate()
        {
            Console.WriteLine("Hello EveryOne");
            Console.ReadLine();
        }
    }
}



