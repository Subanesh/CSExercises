using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises 
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
           // int[] month = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            int[] sales=new int[12];
           
           

            for (int i = 0; i < sales.Length; i++)
            {
                Console.Write("Enter Sales for month {0}:",i);
                sales[i] = int.Parse(Console.ReadLine());      
            }
            

            int max = sales[0], min = sales[0];

            for (int i = 0; i < 12; i++)
            {
                if (max < sales[i])
                {
                    max = sales[i];
                }

                if (min > sales[i])
                {
                    min = sales[i];
                }
            }

            for (int i = 0; i < 12; i++)
            {
                if (max == sales[i])
                {
                    max = i;
                }

                if (min == sales[i])
                {
                    min = i;
                }
            }

            Console.WriteLine("Max{0}", sales.Max());
            Console.WriteLine("Min:{0}", sales.Min());

            Console.WriteLine("Maximum Sales:{0}",max);
            Console.WriteLine("Minimum Sales:{0}", min);
            Console.WriteLine("Average Sales:{0}", sales.Average());
            Console.ReadLine();
        }
    }
}
