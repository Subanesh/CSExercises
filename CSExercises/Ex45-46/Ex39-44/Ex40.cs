using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Square Roots of Number between 1 and 25");
            for (int i=1;i<=25;i++)
            {
                Console.WriteLine("Square Root of:{0} is {1}", i, SQT(i));
            }

            Console.ReadLine();
        }

        public static double SQT(int y)
        {
            double X = Math.Sqrt(Convert.ToDouble(y));
            return X;

        }
    }
}
