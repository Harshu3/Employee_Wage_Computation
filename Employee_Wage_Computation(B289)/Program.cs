﻿using System;

namespace Employee_Wage_Computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total Wage is: " + CalculateEmpWage());
        }
        public static int CalculateEmpWage()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int NUMBER_OF_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;

            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            Random random = new Random();
            while (day <= NUMBER_OF_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
            {
                int employeeAttendance = random.Next(0, 3); //0 to 2
                switch (employeeAttendance)
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
                day++;
                totalHrs += empHrs;
                totalWage += empWage;
                Console.WriteLine("Employee wage is:" + empWage);
            }
            Console.WriteLine("Total Wage for {0} days and {1} hrs is:{2} ", (day - 1), totalHrs, totalWage);
            return totalWage;
        }
    }
}