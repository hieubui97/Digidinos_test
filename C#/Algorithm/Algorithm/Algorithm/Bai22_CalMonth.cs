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

            double target = money + money * rate / 100;

            return recursion(target, 1, money, rate);
        }

        private static int recursion(double target, int month, double money, float rate)
        {
            if (target >= 2 * money)
            {
                return month;
            }

            return recursion(target += target * rate / 100, month + 1, money, rate);
        }
    }
}
