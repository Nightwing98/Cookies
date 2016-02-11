using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanClasses.Day1
{
    class Student
    {
        //параметры
        private string name;
        private int id;
        private List<Lesson> myClasses = new List<Lesson>();

        //конструкторы
        public Student()
        {
            this.name = "Unknown";
            this.id = 0;
        }

        public Student(string name)
        {
            this.name = name;
            this.id = 0;
        }

        public Student(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        //методы
        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetId()
        {
            return this.id;
        }

        //method to print all my classes
        public void PrintClasses()
        {
            for (int i = 0; i < this.myClasses.Count; i++)
            {
                Console.WriteLine(this.myClasses[i].GetName() + " " + this.myClasses[i].GetCredits());
            }
        }
        public void PrintClasses(StreamWriter outp)
        {
            for (int i = 0; i < this.myClasses.Count; i++)
            {
                outp.WriteLine(this.myClasses[i].GetName() + " " + this.myClasses[i].GetCredits());
            }
        }


        public void AddClassFromConsole()
        {
            Console.WriteLine("enter lesson info:");
            Lesson tl = new Lesson(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            this.myClasses.Add(tl);
        }

        public void AddClassFromConsole(StreamReader inp)
        {
            Lesson tl = new Lesson(inp.ReadLine(), inp.ReadLine(), int.Parse(inp.ReadLine()), int.Parse(inp.ReadLine()), double.Parse(inp.ReadLine()));
            this.myClasses.Add(tl);
        }

        //method that print overall gpa
        public double GetAverageGrade()
        {
            double sum = 0;
            for (int i = 0; i < this.myClasses.Count; i++)
            {
                sum += this.myClasses[i].GetGrade();
            }

            return sum / myClasses.Count;
        }

        public string GetMaxGrade()
        {
            double max = this.myClasses[0].GetGrade();
            string nameOfSubject = this.myClasses[0].GetName();
            for (int i = 0; i < this.myClasses.Count; i++)
            {
                if (max < this.myClasses[i].GetGrade())
                {
                    max = this.myClasses[i].GetGrade();
                    nameOfSubject = this.myClasses[i].GetName();
                }

            }
            return nameOfSubject + " " + max;
        }
    }
}
