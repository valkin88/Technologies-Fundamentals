using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNameOfEmployee = "Amanda";
            string lastNameOfEmployee = "Jonson";
            byte ageOfEmployee = 27;
            char genderOfEmployee = 'f';
            long personalIdOfEmployee = 8306112507;
            int employeeNumber = 27563571;

            Console.WriteLine($"First name: {firstNameOfEmployee}\nLast name: {lastNameOfEmployee}\nAge: {ageOfEmployee}\nGender: {genderOfEmployee}\nPersonal ID: {personalIdOfEmployee}\nUnique Employee number: {employeeNumber}");
        }
    }
}
