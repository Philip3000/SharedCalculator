using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator
{
    public static class BasicMath 
    {
        //Takes two doubles as parameters and ADDS them together where sum is the result being return
        public static double Addition(double x, double y)
        {
            double sum = 0;
            sum = x + y;
            return sum;
        }
        //Takes two doubles as parameters and SUBTRACTS them where sum is the result being return
        public static double Subtraction(double x, double y)
        {
            double sum = 0;
            sum = x - y;
            return sum;
        }
        //Takes two doubles as parameters and MULTIPLIES them where sum is the result being return
        public static double Multiplication(double x, double y)
        {
            double sum = 0;
            sum = x * y;
            return sum;
        }
        //Takes two doubles as parameters and DIVIDES them where sum is the result being return
        public static double Division(double x, double y)
        {
            double sum = 0;
            sum = x / y;
            return sum;
        }
    }
}
