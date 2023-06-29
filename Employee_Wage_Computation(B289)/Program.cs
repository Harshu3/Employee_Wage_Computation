using System;

namespace Employee_Wage_Computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0, isPresent = 1, empWage = 0;
            const int EMP_RATE_PER_HR = 20;

            Console.WriteLine("Welcome to Employee Wage Computation Problem!");
            Random random = new Random();
            int empAttendance = random.Next(0, 2); //0 or 1
            if (empAttendance == isPresent)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Daily Wage is: " + empWage);
        }
    }
}