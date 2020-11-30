using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    class Bai22_CalMonth
    {
        public static int calMonth(double money, float rate)
        {
            if (money <= 0 || money == 1 || rate <= 0)
                return 0;

            int month = 1;
            double target = money + money * rate / 100;
            while (target < 2 * money)
            {
                target += target * rate / 100;
                month++;
            }

            return month;
        }

        public static int calMonthRecursion(double money, float rate)
        {
            if (money <= 0 || money == 1 || rate <= 0)
                return 0;

            double target = 2 * money;
            return recursion(money, rate, 1, target);
        }

        private static int recursion(double money, float rate, int month, double target)
        {
            double x = money + money * rate / 100;
            if (x >= target)
            {
                return month;
            }

            return recursion(x, rate, month + 1, target);
        }
    }
}
