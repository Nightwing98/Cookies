using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanClasses.lab2
{
    class Program
    {
        static void Main3()
        {
            StreamReader inp = new StreamReader(@"C:\programs\input.txt");
            using (StreamWriter outp = new StreamWriter(@"C:\programs\outMINMAX.txt"))
            {
                int kol = int.Parse(inp.ReadLine());
                int[] m = new int[kol];
                for (int i = 0; i < kol; i++)
                {
                    m[i] = int.Parse(inp.ReadLine());
                }
                int MAX = m[0];
                int MIN = m[0];
                for (int i = 0; i < kol; i++)
                {
                    if (MAX < m[i])
                    {
                        MAX = m[i];
                    }
                    if (MIN > m[i])
                    {
                        MIN = m[i];
                    }

                }
                outp.WriteLine("the min is" +" "+ MIN + " " + "the max is" + " " + MAX);

                inp.Close();
                outp.Close();
            }
        }
    }
}
