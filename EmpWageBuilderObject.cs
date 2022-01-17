using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    //class UC_9
    //{
        public class EmpWageBuilderObject
        {
            //class UC_8
            //{
            public const int PartTime = 2;
            public const int IS_FULL_TIME = 1;

            private string  company;
            private int empRatePerhr;
            private int numOfWorkingDays;
            private int maxHrInMonth;
            private int totalEmpWage;

            public EmpWageBuilderObject (string company, int empRatePerhr, int numOfWorkingDays, int maxHrInMonth)
            {
                this.company = company;
                this.empRatePerhr = empRatePerhr;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHrInMonth = maxHrInMonth;
                this.totalEmpWage = 0;

            }
            public void computeEmpWage()
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
                totalEmpWage = totalEmpHrs * this.empRatePerhr;
                Console.WriteLine("Total Emp Wage for Company : " + company + "is" + totalEmpWage);
               // return totalEmpWage;
            }

            public string tostring()
            {
                return "Total emp wage for company : " + this.company + "is" + this.totalEmpWage;
            }
        }
  
}
