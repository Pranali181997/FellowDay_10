using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    interface EmployeeWageClass
    {
        public int ComputeEmpWage(string company, int empRatePerhr, int numOfWorkingDays, int maxHrInMonth);

    }
}
