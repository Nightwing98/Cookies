using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanClasses.lab1
{
    class Complex
    {
      private int a, b;
        public int GetA()
        {
            return a;
        }
        public int GetB()
        {
            return b;
        }
        public Complex()
        {
            a = 0;
            b = 0;

        }
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
            
        public Complex(int c)
        {
            this.a = c;
            this.b = c;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        public static Complex operator +(Complex c1,Complex c2)
        {
            Complex result = new Complex(c1.GetA() + c2.GetA(), c1.GetB()+ c2.GetB());
            return result;
        }

        public static Complex operator -(Complex c1,Complex c2)
        {
            Complex result = new Complex(c1.GetA() - c2.GetA(), c1.GetB() - c2.GetB());
            return result;
        }
    }
}
