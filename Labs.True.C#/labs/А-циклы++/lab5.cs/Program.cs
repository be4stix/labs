using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.cs /*A-циклы*/
{
    class Program
    {
        static void Main(string[] args)
        {

            double  a = 1, x,sum = 0;
            int k, n,f=1;

            Console.WriteLine("Vvedite x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite k");
            k = int.Parse(Console.ReadLine());

            for (n = 0; n < k; n++)
            {
                for (int i = 0; i < n; i++)
                {
                    f *= n + 1;
                }
                a *= Math.Pow(x,n)/f;
                sum += a;
                f = 1;
                }

            Console.WriteLine($"При k ={k}");
            Console.WriteLine($"При x ={x}");
            Console.WriteLine($"sum ={sum}");

            Console.ReadLine();
            }
        }
    }

