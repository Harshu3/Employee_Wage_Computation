using System;

namespace Employee_Wage_Computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0, empWage = 0;
            const int EMP_RATE_PER_HR = 20, IS_FULL_TIME = 1, IS_PART_TIME = 2;

            Console.WriteLine("Welcome to Employee Wage Computation Problem!");
            Random random = new Random();
            int empAttendance = random.Next(0, 3); //0 to 2
            if (empAttendance == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else if (empAttendance == IS_PART_TIME)
            {
                Console.WriteLine("Employee is Part-time Present");
                empHrs = 4;
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