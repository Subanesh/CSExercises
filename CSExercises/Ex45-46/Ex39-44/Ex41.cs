
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String 1");
            string s1=Console.ReadLine();
            Console.WriteLine("Enter String 2");
            string s2=Console.ReadLine();

            Console.WriteLine("S2 Occurs in S1 is:{0}", InString(s1, s2));
            Console.ReadLine();

        }
        public static bool InString(string s1, string s2)
        {
            bool result = false;
            if(s1.ToLower().Contains(s2.ToLower()))
            {
                result= true;
            }
            else
            {

                result= false;
            }

            return result;
        }
    }
}
