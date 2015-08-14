using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number which you want to square:");
            int x = int.Parse(Console.ReadLine());
            int s = x * x;
            Console.WriteLine("Square:{0}",x*x);
            Console.ReadLine();

        }
    }
}
