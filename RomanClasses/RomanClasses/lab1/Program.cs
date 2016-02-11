using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanClasses.lab1
{
    class Program
    {
static void Main2()
        {
            Complex nb = new Complex(10,7);
            Complex mp = new Complex(9);
            Complex res = nb + mp;
            Console.WriteLine(res.ToString());
           // Student bg = new Student();
            Console.ReadKey();
        }
    }
}
