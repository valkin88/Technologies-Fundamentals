using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;
using System.IO;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("Input.txt");
            int numberOfStudents = int.Parse(input[0]);
            List<Student> studentsData = new List<Student>();
            File.Delete("output.txt");
            for (int i = 1; i <= numberOfStudents; i++)
            {
                Student students = new Student();
                string[] inputOfStudents = input[i].Split(' ').ToArray();
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
            var output = studentsData.OrderBy(x => x.Name)
                                     .ThenByDescending(d => d.AverageGrade)
                                     .Select(x => $"{x.Name} -> {x.AverageGrade:f2}")
                                     .ToList();
            File.WriteAllLines("otput.txt", output);

            
        }

    }

    public class Student
    {
        public string Name;
        public List<double> Grades = new List<double>();
        public double AverageGrade;

    }
}
