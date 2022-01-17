using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{

    public class ComputeEmpWage
    {
        public string company;
        public int empRatePerhr;
        public int numOfWorkingDays;
        public int maxHrInMonth;
        public int totalEmpWage;

        public ComputeEmpWage(string company, int empRatePerhr, int numOfWorkingDays, int maxHrInMonth)
        {
            this.company = company;
            this.empRatePerhr = empRatePerhr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrInMonth = maxHrInMonth;
            this.totalEmpWage = 0;
        }

        public void setTototalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string tostring()
        {
            return "Total emp wage for company : " + this.company + "is" + this.totalEmpWage;
        }

    }
    
}

                   



