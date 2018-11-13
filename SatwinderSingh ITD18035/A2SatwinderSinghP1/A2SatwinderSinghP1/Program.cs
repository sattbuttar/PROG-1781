using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SatwinderSinghP1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*STEP 1*/


            Console.WriteLine("Press 1 for CANADIAN CITIZEN and 2 for INTERNATIONAL STUDENT");
            string g = Console.ReadLine();
            double m = double.Parse(g);
            

            if (m == 1)
            {
                Console.WriteLine("Please enter age");
                string h = Console.ReadLine();
                double n = double.Parse(h);
                if (n <= 18)
                {
                    Console.WriteLine("Base fee ($300) + 13% HST");
                    double a = 300 + (0.13 * 300);
                    Console.WriteLine("Student should pay $ " + a);
                }

                else if (n <= 49)
                {
                    Console.WriteLine("Base fee ($500) + 13% HST");
                    double a = 500 + (0.13 * 500);
                    Console.WriteLine("Student should pay $ " + a);
                }

                else
                {
                    Console.WriteLine("Base fee ($400) + 13% HST");
                    double a = 400 + (0.13 * 400);
                    Console.WriteLine("Student should pay $ " + a);
                }

            }

            else if (m == 2)
            {
                Console.WriteLine("Please enter age");
                string j = Console.ReadLine();
                double k = double.Parse(j);
                if (k <= 18)
                {
                    Console.WriteLine("Base fee ($300+$100=$400) + 13% HST");
                    double a = 400 + (0.13 * 400);
                    Console.WriteLine("Student should pay $ " + a);
                }

                else if (k <= 49)
                {
                    Console.WriteLine("Base fee ($500+$100=$600) + 13% HST");
                    double a = 600 + (0.13 * 600);
                    Console.WriteLine("Student should pay $ " + a);
                }


                else
                {
                    Console.WriteLine("Base fee ($400+$100=$500) + 13% HST");
                    double a = 500 + (0.13 * 500);
                    Console.WriteLine("Student should pay $ " + a);
                }


            }

            /*STEP 2*/

            Console.WriteLine("Student should also pay registration fee");
            Console.WriteLine("Enter 7 for FALL month (Sept., Oct., Nov., or Dec.) or" +
                "Enter 8 for WINTER month (Jan., Feb., Mar. or Apr.) or" +
                "Enter 9 for SUMMER month (May, Jun., Jul. or Aug.)");
            string s = Console.ReadLine();
            double x;
            switch(s)
            {
                case "7":
                    {
                        Console.WriteLine("$250 + 13% HST");
                        x =250+(0.13*250);
                        Console.WriteLine("Registration fee is : $" + x);
                        break;
                    }

                case "8":
                    {
                        Console.WriteLine("$220 + 13% HST");
                        x = 220 + (0.13 * 220); 
                        Console.WriteLine("Registration fee is : $" + x);
                        break;
                    }

                case "9":
                    {
                        Console.WriteLine("$150 + 13% HST");
                        x = 150 + (0.13 * 150); 
                        Console.WriteLine("Registration fee is : $" + x);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("please enter only given value");
                        break;
                    }
            }

            


        }




    }
}
    
