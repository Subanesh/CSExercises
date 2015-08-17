using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter values x1,y1,x2,y2");

            int x1 = int.Parse(Console.ReadLine());

            int y1 = int.Parse(Console.ReadLine());

            int x2 = int.Parse(Console.ReadLine());

            int y2 = int.Parse(Console.ReadLine());

            double p1 = Math.Pow((x2 - x1), 2);

            double p2 = Math.Pow((y2 - y1), 2);

            double d = Math.Sqrt(p1 + p2);

            Console.WriteLine("Distance:{0}", d);

            Console.ReadLine();
        }
    }
}
