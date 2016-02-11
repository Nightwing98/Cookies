using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanClasses.Day1
{
    class Lesson
    {
        private string name;//name of lesson
        private string teacher;//teacher name
        private int number;
        private int credit;
        private double grade;

        //Создать конструктор который принимает все параметры
        public Lesson(string name,string teacher,int number,int credit,double grade)
    {
        this.name = name;
        this.teacher = teacher;
        this.number = number;
        this.credit = credit;
        this.grade = grade;
    } 
        //Создать только Getter для всех параметров
        public string Getnames()
        {
            return name + " " + teacher;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetTeacher()
        {
            return this.teacher;
        }
        public int GetNumber()
        {
            return this.number;
        }
        public int GetCredits()
        {
            return this.credit;
        }
        public double GetGrade()
        {
            return this.grade;
        }
    }
}
//метод получения gpa