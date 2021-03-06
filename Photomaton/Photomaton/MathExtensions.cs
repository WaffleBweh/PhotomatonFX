﻿using System;
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
        /// usage : myInteger.lcm(myOtherInteger)
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

        /// <summary>
        /// Returns the power of two of the current number
        /// usage : myInteger.PowerOfTwo()
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int PowerOfTwo(this int a)
        {
            int result = 0;

            for (; a > 1; a /= 2)
            {
                result++;
            }

            return result;
        }

        /// <summary>
        /// Forces a number between a set range
        /// </summary>
        /// <param name="value"></param>
        /// <param name="inclusiveMinimum"></param>
        /// <param name="inclusiveMaximum"></param>
        /// <returns></returns>
        public static int LimitToRange(this int value, int inclusiveMinimum, int inclusiveMaximum)
        {
            if (value < inclusiveMinimum) { return inclusiveMinimum; }
            if (value > inclusiveMaximum) { return inclusiveMaximum; }
            return value;
        }
    }
}
