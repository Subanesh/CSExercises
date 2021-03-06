using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[] d = new int[4];
            int[,] std = new int[,]{{56,84,68,29},
                                       {94,73,31,89},                            
                                       {41,63,36,90},
                                       {99,9,18,17},
                                       {62,3,65,75},
                                       {40,96,53,23},
                                       {81,15,27,30},
                                       {21,70,100,22},
                                       {88,50,13,12},
                                       {48,54,52,78},
                                       {64,71,67,25},
                                       {16,93,46,72}    
            };

            Console.WriteLine("SNO\tSub1\tSub2\tSub3\tSub4\tTotal");

            Console.WriteLine("---------------------------------------------------------");

            for (int i = 0; i <12; i++)
            {
                int tstd = 0;
                Console.Write("{0}\t", i);
                for (int j = 0; j < 4; j++)
                {
                    tstd = tstd + std[i, j];

                    Console.Write("{0}\t", std[i,j]);
                }
                Console.Write("{0}\t", tstd);
                Console.WriteLine("");
            }

            //Subject Average
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("SAVG\t");
                for (int j = 0; j < 4; j++)
                {
                    
                    int savg = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        savg = savg + std[i, j];


                }
                  
                    Console.Write("{0}\t", savg / 12);

                   

                    for (int k = 0; k < 4; k++)
                    {
                        d[k]= savg / 12;
                    }
            }


            //Standard Deviation
                Console.WriteLine("");
                Console.Write("SAVG\t");
                for (int j = 0; j < 4; j++)
                {

                    int sum = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        int ds = std[i, j] - d[j];

                       int sds = ds * ds;
                       sum = sum + sds;

                    }

                    double sd=Math.Sqrt(sum / 12);
                   
                    Console.Write("{0:0.00}\t",sd );
                }
        //Over all Sum

                Console.WriteLine("");
                Console.Write("Overall Average\t");
                int tsum = 0;
                for (int i = 0; i < 12; i++)
                {
                   int ssum = 0;
                for (int j = 0; j < 4; j++)
                {

                    ssum = ssum + std[i, j];

                    }

                tsum = tsum + ssum;

                }

                double wavg = Convert.ToDouble(tsum) / Convert.ToDouble(12 * 4);

                Console.Write("{0:0.00}\t", wavg);

                Console.ReadLine();

                   
                

               

        }
    }
}
