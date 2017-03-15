using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photomaton
{
    public static class MathExtensions
    {
        /// <summary>
        /// Find the lowest common multiple of two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int lcm(this int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num1 * num2;
        }

        public static int PowerOfTwo(this int a)
        {
            int result = 0;

            for (; a > 1; a /= 2)
            {
                result++;
            }

            return result;
        }
    }
}
