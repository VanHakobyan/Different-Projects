using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_functions_iterator
{
    class Program
    {
        static IEnumerable<float> GetCalculatedPow(int degree,float num )
        {
          
            for (int i = 0; i < degree; i++)
            {
                yield return num ;
                num *= num;

            }

        }

        static void Main(string[] args)
        {
            foreach (var item in GetCalculatedPow(2,8.6f))
            {
                Console.WriteLine(item);
            }
        }
    }
}
