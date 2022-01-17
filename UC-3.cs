using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class UC_3
    {
        public void AddPartTime()
        {
            //constants
            int PartTime = 2;
            int IS_FULL_TIME = 1;
            int RatePerHr = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if (empCheck == PartTime)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * RatePerHr;
            Console.WriteLine("Daily Emp Wage : " + empWage);
        }
    }
}
    
