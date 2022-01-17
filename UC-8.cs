using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class ComputeEmpWagesclass : EmployeeWageClass
    {
        //class UC_8
        //{
            public const int PartTime = 2;
            public const int IS_FULL_TIME = 1;
            public int ComputeEmpWage(string company, int empRatePerhr, int numOfWorkingDays, int maxHrInMonth)
            {
                //variables
                int empHrs = 0;
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;

                while (totalEmpHrs <= maxHrInMonth && totalWorkingDays <= numOfWorkingDays)
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
                int totalEmpWage = totalEmpHrs * empRatePerhr;
                Console.WriteLine("Total Emp Wage : " + totalEmpWage);
                return totalEmpWage;
            }
        }

    }




