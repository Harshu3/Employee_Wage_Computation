using System;

namespace Employee_Wage_Computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0, empWage = 0, totalWage = 0, day = 0, totalHrs = 0;
            const int EMP_RATE_PER_HR = 20, IS_FULL_TIME = 1, IS_PART_TIME = 2, NUM_OF_WORKING_DAYS = 20, MAX_WORKING_HRS = 100;

            Console.WriteLine("Welcome to Employee Wage Computation Problem!");
            Random random = new Random();
            while (day <=NUM_OF_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
            {
                int empAttendance = random.Next(0, 3); //0 to 2
                switch (empAttendance)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is Full-time Present");
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is Part-time Present");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }

                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("Employee Wage for day{0} and {1}hrs is: {2} ", day, empHrs, empWage);
                day++;
                totalHrs += empHrs;
                totalWage += empWage;
            }
            Console.WriteLine("Totla Wage for {0} days and {1} hrs is: {2} ", (day - 1), totalHrs, totalWage);
        }
    }
}