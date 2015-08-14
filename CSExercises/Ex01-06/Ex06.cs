using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Integer Number");
            int d = int.Parse(Console.ReadLine());
            double s = Math.Sqrt((double)d);
            Console.WriteLine("Square Root:{0}", s);
        }
    }
}
