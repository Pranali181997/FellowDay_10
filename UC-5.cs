using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class UC_5
    {

        //constants
        public const int PartTime = 2;
        public const int IS_FULL_TIME = 1;
        public const int RatePerHr = 20;
        public const int Num_Of_Working_Days = 2;
        public void WageForMonth()
        {

            //variables
            int empHrs = 0;
            int empWage = 0;

            for(int day =0; day< Num_Of_Working_Days; day++)
            { 
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case PartTime:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * RatePerHr;
            Console.WriteLine("Daily Emp Wage : " + empWage);
            }
        }
    }

}

