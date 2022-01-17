using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class UC_7
    {
        //constants
        public const int PartTime = 2;
        public const int IS_FULL_TIME = 1;
        public const int RatePerHr = 20;
        public const int Num_Of_Working_Days = 2;
        public const int Max_Hr_In_Month = 10;
        public static int computeWages()
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= Max_Hr_In_Month && totalWorkingDays <= Num_Of_Working_Days)
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + "Emp Hrs :" + empHrs);
                
            }
            int totalEmpWage = totalEmpHrs * RatePerHr;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }
    }

}


    
