using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Mark
    {
        public String subject;
        public int mark;
        public Mark (String subject, int mark)
        {
            this.subject = subject;
            this.mark = mark;
        }
    }
    class Student
    {
        public String name;
        public Mark[] marks;
        public Student (String name, Mark[] marks)
        {
            this.name = name;
            this.marks = marks;
        }

        public double GetAvgMark()
        {
            int sum = 0;
            foreach(Mark mark in marks)
            {
                sum += mark.mark;
            }
            return sum / marks.Length;
        }
        public void ResetAllMarks()
        {
            foreach (Mark mark in marks)
            {
                mark.mark = 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Qwert", new Mark[] { new Mark("math", 5), new Mark("eng", 4), new Mark("rus",3) });
            System.Console.WriteLine(student.name + " " + student.GetAvgMark());
            student.ResetAllMarks();
            System.Console.WriteLine(student.name + " " + student.GetAvgMark());
            System.Console.ReadKey();

        }
    }
}
