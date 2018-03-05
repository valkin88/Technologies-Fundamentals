using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> studentsData = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                Student students = new Student();
                string[] inputOfStudents = Console.ReadLine().Split(' ');
                students.Name = inputOfStudents[0];
                for (int j = 1; j < inputOfStudents.Length; j++)
                {
                    students.Grades.Add(double.Parse(inputOfStudents[j]));
                }
                students.AverageGrade = students.Grades.Average();

                if (students.AverageGrade >= 5.00)
                {
                    studentsData.Add(students);
                }
            }

            studentsData = studentsData.OrderBy(x => x.Name).ThenByDescending(d => d.AverageGrade).ToList();

            foreach (var student in studentsData)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
            
        }

    }

    public class Student
    {
        public string Name;
        public List<double> Grades = new List<double>();
        public double AverageGrade;

    }
}
