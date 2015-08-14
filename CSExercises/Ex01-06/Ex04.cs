using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Double Precision Number");
            double d = double.Parse(Console.ReadLine());
            double s = Math.Sqrt(d);
            Console.WriteLine("Square Root:{0}",s);
        }
    }
}
