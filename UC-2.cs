using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class UC_2
    {
        public void DailyWages()
        {
            //constants
            int IS_FULL_TIME = 1;
            int RatePerHr = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 4;
            }
            empWage = empHrs * RatePerHr;
            Console.WriteLine("Daily Emp Wage : " + empWage);
        }
    }
}
    

