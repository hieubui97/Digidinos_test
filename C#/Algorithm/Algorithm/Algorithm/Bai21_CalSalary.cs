using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    class Bai21_CalSalary
    {
        public static double calSalary(double salary, int n)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                salary += salary * 0.1;
            }

            return salary;
        }

        public static double calSalaryRecursion(double salary, int n)
        {
            if (n < 1)
                return salary;

            return calSalaryRecursion(salary, n - 1) + calSalaryRecursion(salary, n - 1)*0.1;
        }
    }
}
