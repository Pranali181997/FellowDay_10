using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    //class UC_10
    //{
    public class EmpWageBuilderObject1
    {
        public string company;
        public int empRatePerhr;
        public int numOfWorkingDays;
        public int maxHrInMonth;
        public int totalEmpWage;

        public EmpWageBuilderObject1(string company, int empRatePerhr, int numOfWorkingDays, int maxHrInMonth)
        {
            this.company = company;
            this.empRatePerhr = empRatePerhr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrInMonth = maxHrInMonth;
            //this.totalEmpWage = totalEmpWage;
        }

        public void setTototalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string tostring()
        {
            return "Total emp wage for company : " + this.company + "is" + this.totalEmpWage;
        }


        public class EmpWageBuilderArray
        {
            public const int PartTime = 2;
            public const int IS_FULL_TIME = 1;

            private int numOfCompany = 0;
            private EmpWageBuilderObject1[] EmpWageBuilderObject1array;

            public EmpWageBuilderArray()
            {
                this.EmpWageBuilderObject1array = new EmpWageBuilderObject1[5];
            }

            public void addcompanyEmpWage(string company, int empRatePerhr, int numOfWorkingDays, int maxHrInMonth)
            {

                EmpWageBuilderObject1array[this.numOfCompany] = new EmpWageBuilderObject1(company, empRatePerhr, numOfWorkingDays, maxHrInMonth);
                numOfCompany++;

            }
            public void ComputeEmpWage()
            {
                for (int i = 0; i < numOfCompany; i++)
                {
                    EmpWageBuilderObject1array[i].setTototalEmpWage(this.ComputeEmpWage(this.EmpWageBuilderObject1array[i]));
                    Console.WriteLine(this.EmpWageBuilderObject1array[i].ToString());
                }
            }
            private int ComputeEmpWage(EmpWageBuilderObject1 EmpWageBuilderObject1)
            {
                //variables
                int empHrs = 0;
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;

                while (totalEmpHrs <= EmpWageBuilderObject1.maxHrInMonth && totalWorkingDays < EmpWageBuilderObject1.numOfWorkingDays)
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

                    Console.WriteLine("Days#:" + totalWorkingDays + "Emp Hrs " + empHrs);
                }
               return totalEmpHrs= EmpWageBuilderObject1.empRatePerhr;
            }


        }

    }
}
