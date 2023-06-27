using System;

namespace Employee_Wage_Computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            Console.WriteLine("Welcome to Employee Wage Computation Problem!");
            Random random = new Random();
            int empAttendance = random.Next(0, 2); //0 or 1
            if (empAttendance == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}