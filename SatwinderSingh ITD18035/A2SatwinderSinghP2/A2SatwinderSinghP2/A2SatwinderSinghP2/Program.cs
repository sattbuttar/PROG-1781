using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SatwinderSinghP2
{
    class Program
    {
        static double rec(double r , double p)
        {
            double rec;
            rec = 4 / 3 * p * r * r * r;
            return rec;
        }
        static double rec(double g,double h, double p)
        {
            double rec;
            rec = p * g * g *h;
            return rec;
        }
        static int rec(int l, int b, int h)
        {
            int rec;
            rec = l * b * h ;
            return rec;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for sphere or");
            Console.WriteLine("2 for cylinder or");
            Console.WriteLine("3 for rectangular prism");
            string x = Console.ReadLine();
            int y = int.Parse(x);


            if(y==1)
            {
                Console.WriteLine("enter radius");
                string u = Console.ReadLine();
                double r = double.Parse(u);
                double result;
                result = rec(3.14, r);
                Console.WriteLine(" volume of sphere is = " + result);
            }

            else if (y==2)
            {
                Console.WriteLine("enter radius");
                string i = Console.ReadLine();
                double g = double.Parse(i);
                Console.WriteLine("enter height");
                string k = Console.ReadLine();
                double h = double.Parse(k);
                double res;
                res = rec(3.14, g, h);
                Console.WriteLine(" volume of cylinder is = " + res);
            }

            else if (y==3)
            {
                Console.WriteLine("enter length");
                string a = Console.ReadLine();
                int l = int.Parse(a);
                Console.WriteLine("enter breadth");
                string c = Console.ReadLine();
                int b = int.Parse(c);
                Console.WriteLine("enter height");
                string d = Console.ReadLine();
                int h = int.Parse(d);
                int resu;
                resu = rec(l, b, h);
                Console.WriteLine(" volume of rectangular prism is = " + resu);
            }
        }
    }
}
