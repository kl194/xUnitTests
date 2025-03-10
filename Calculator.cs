using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static int[] Add(int[] f1, int[] f2)
        {
            int[] result = new int[2];
            result[0] = f1[0] * f2[1] + f2[0] * f1[1];
            result[1] = f1[1] * f2[1];
            return result;
        }

        public static int[] Subtract(int[] f1, int[] f2)
        {
            int[] result = new int[2];
            result[0] = f1[0] * f2[1] - f2[0] * f1[1];
            result[1] = f1[1] * f2[1];
            return result;
        }

        public static int[] Multiply(int[] f1, int[] f2)
        {
            int[] result = new int[2];
            result[0] = f1[0] * f2[0];
            result[1] = f1[1] * f2[1];
            return result;
        }

        public static int[] Divide(int[] f1, int[] f2)
        {
            int[] result = new int[2];
            result[0] = f1[0] * f2[1];
            result[1] = f1[1] * f2[0];
            return result;
        }
    }
}
