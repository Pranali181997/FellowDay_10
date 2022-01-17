using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
   public interface IComputeEmpWage
    {

        public void addCompanyEmpWage(string company, int empRatePerhr, int numOfWorkingDays, int maxHrInMonth);
        public void computeEmpWage();
        public int getTotalWage(string company);
    }
}
