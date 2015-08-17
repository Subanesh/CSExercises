using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int r;

            int num, sum = 0, temp;

            Console.WriteLine("Enter the number");

            num = int.Parse(Console.ReadLine());

            temp = num;

            while (temp > 0)
            {

                r = temp % 10;

                sum = sum + r * r * r;

                temp = temp / 10;

            }

            if (num == sum)

                Console.WriteLine("{0} is amstrong", num);

            else

                Console.WriteLine("{0} is not amstrong", num);

            Console.ReadLine();
        }
    }
}