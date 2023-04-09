using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4 /*KMB-циклы */
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double n=0,kk,x,sl = 1, sum = 0, tochnost=0 , a = 0.5, b = 0.33;

           Console.WriteLine("Vvedite x");
           x = double.Parse(Console.ReadLine());

           Console.WriteLine("Vvedite tochnost");
           tochnost = double.Parse(Console.ReadLine());
            /*
            while (System.Math.Abs(sl) > tochnost)
            {   

                kk = (x - 1) / (x + 1);
                sl *=  1/(2*n+1) * (System.Math.Pow(kk, 2*n+1));
                sum += sl;
                n++;

            }*/

            
            while (System.Math.Abs(sl) > tochnost)
            {
                sl *= 1 / (System.Math.Pow(4, n) + (System.Math.Pow(5, n + 2)));
                n++;
                sum += sl;
            }
            
            double k = 3;
            while( b-a < tochnost)
            {
                b = a;
                a *= (1 - 1 / k);
                Console.WriteLine(a);
                k++;
            } 
            

            Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
