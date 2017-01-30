using System;

using System.Globalization;
using System.Numerics;


namespace ProbabilityTheory
{
    class Program
    {

        static void Main(string[] args)
        {
            BigInteger sum = 1;
            //var sumStud = 1;
            //var year = 365;
            //var student = 23;
            //for (var i = year - student; i < year; i++)
            //{
            //    sum *= i;
            //}
            //for (var i = 1; i < student; i++)
            //{
            //    sumStud *= i;
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(sumStud);
            //sum = sum / sumStud;
            //Console.WriteLine(1 - sum);

            for (int i = 342; i <= 365; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine(sum);

            BigInteger sum2 = 1;
            for (UInt64 i = 1; i <= 23; i++)
            {
                sum2 = sum2 * i;
            }
           
            Console.WriteLine(sum2);
            Console.WriteLine(sum / sum2);

        }
    }
}
