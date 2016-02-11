using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanClasses.lab2
{
    class Program1
    {
        static void Main()
        {
            StreamReader inp = new StreamReader(@"C:\programs\input.txt");
            using (StreamWriter outp = new StreamWriter(@"C:\programs\MINMAX.txt"))
            {
                string line;
                int max = 0, min = 999999;
                while ((line = inp.ReadLine()) != null)
                {
                    int nline = int.Parse(line);
                    bool prostoe = true;
                    for (int i = 2; i < Math.Abs(nline); i++)
                    {
                        if (nline%2== 0)
                        {
                            prostoe = false;
                            break;
                        }
                    }
                    if (min > nline && prostoe) min = nline;
                    if (max < nline && prostoe) max = nline;

                }
            outp.WriteLine(min + " "+ max);
            inp.Close();
            outp.Close();
            }
            

        }
    }
}
