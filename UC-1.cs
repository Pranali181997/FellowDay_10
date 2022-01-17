using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class UC_1
    {
        public void PresentOrAbsent()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Present");
            }
        }
    }
}