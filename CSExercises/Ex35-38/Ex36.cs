
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string input = Console.ReadLine();

            string r = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                r += input[i].ToString();
            }

            if (input == r)
            {
                Console.WriteLine("Palindrome");
            }

            else
            {
                Console.WriteLine("Not Palindrome");
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter Pharse");
            string s = Console.ReadLine();

            string s1 = s.ToLower().Replace(" ", "");
            string s2 = s1.ToLower().Replace(",", "");
            string s3 = s2.ToLower().Replace("!", "");
           // Console.WriteLine(s3);
            string rp = "";
            for (int j = s3.Length - 1; j >= 0;j-- )
            {
                rp+=s3[j].ToString();
            }
          //  Console.WriteLine(rp);
            if(s3==rp)
            {
                Console.WriteLine("Palindrome");

            }

            else
            {
                Console.WriteLine("Not Palindrome");
            }

                Console.ReadLine();

        }
    }
}
