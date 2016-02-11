using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanClasses.Day1
{
    class Program
    {
        static void Main1(string[] args)
        {
            StreamReader inputStream =
                new StreamReader(@"C:\programs\input.txt");
            using (StreamWriter outputstream =
                new StreamWriter(@"C:\programs\my result.txt"))
            {
                Student st;
                st = new Student(inputStream .R

                outputstream .WriteLine(st.GetName() + st.GetId());
                for (int i = 0; i < 3; i++)
                {
                    st.AddClassFromConsole(inputStream);
                }
                st.PrintClasses(outputstream );
                outputstream .WriteLine(st.GetAverageGrade());
                outputstream .WriteLine(st.GetMaxGrade());
                inputStream.Close();
                outputstream.Close();
            }
                
                Console.Read();
        }
    }
}
