using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2,2);
            Complex c2 = new Complex(3,3);

            Complex c3 = new Complex();

            c3 = c1 - c2;
            Console.WriteLine(c3);

            int arg = c3.Arg();
            double abs = c3.Abs(); 


            Console.ReadLine();
        }
    }
}
