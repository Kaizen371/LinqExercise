using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sum = numbers.Sum();
            Console.WriteLine(sum);

            //TODO: Print the Average of numbers
            var average = numbers.Average();
            Console.WriteLine(average);

            //TODO: Order numbers in ascending order and print to the console
            var ascending = numbers.OrderBy(x => x).ToArray();
            Console.WriteLine("Ascending");
            foreach (var number in ascending)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-----------------");
            //TODO: Order numbers in descending order and print to the console
            var descending = numbers.OrderByDescending(x => x).ToArray();
            Console.WriteLine("Descending");
            foreach (var number in descending){Console.WriteLine(number);}
            Console.WriteLine("-----------------");
            

            //TODO: Print to the console only the numbers greater than 6
            var greaterThan = numbers.Where(x => x > 6).ToArray();
            Console.WriteLine("Greater than 6 ");
            foreach (var number in greaterThan){Console.WriteLine(number);}
            Console.WriteLine("-----------------");

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            
            Console.WriteLine("4 Numbers:");
            var ordered = numbers.OrderBy(x => x).ToArray();
            
            
            foreach (var number in numbers.Take(4))
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("------------------");
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 24;
            var descendingAge = numbers.OrderByDescending(x => x).ToArray();
            foreach (var number in descendingAge){Console.WriteLine(number);}
            Console.WriteLine("------------------");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();
            
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees.Insert(employees.Count, new Employee("John", "Johnson", 23, 2));
            
            Console.WriteLine("Employees:");
            foreach (var employee in employees){Console.WriteLine(employee.FullName);}
            Console.WriteLine("------------------");

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
                Console.WriteLine("Employees with c or s:");
            var employeeNames = employees.Where(name => name.FirstName.StartsWith("S") || name.FirstName.StartsWith("C")).OrderBy(name => name.FirstName)
                .ToList();
            foreach (var employee in employeeNames){Console.WriteLine(employee.FullName);}
            Console.WriteLine("------------------");
    
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employee Ages:");
            var employeeAges = employees.Where(employee => employee.Age > 26).OrderBy(employee => employee.Age)
                .ThenBy(employee => employee.FirstName);
            foreach (var employee in employeeAges)
            {
                Console.WriteLine($"{employee.FirstName} {employee.Age}");
            }
            Console.WriteLine("------------------");
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Years of experience sum:");
            var yoe = employees.Where(employee =>
                employee.YearsOfExperience <= 10 && employee.Age > 35);
            Console.WriteLine(yoe.Sum(employee => employee.YearsOfExperience));
            Console.WriteLine("------------------");
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Years of experience average");
            Console.WriteLine(yoe.Average(employee => employee.YearsOfExperience));
            Console.WriteLine("------------------");
            

           
            


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
