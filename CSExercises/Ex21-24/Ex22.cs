
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            int b = int.Parse(Console.ReadLine());

            int num1 = a;
            int num2 = b;
            int temp;

            while (num2 != 0)
            {
                temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
          int   HCF = num1;
          int   LCM = (a * b) / HCF;

          Console.WriteLine("HCF:{0}", HCF);
          Console.WriteLine("LCM:{0}", LCM);

          Console.ReadLine();


        }
    }
}
