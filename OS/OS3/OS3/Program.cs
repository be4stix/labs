using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace OS3
{
    class Program
    {

        static void Main(string[] args)
        {
            
            String n = Console.ReadLine();
            int N = int.Parse(n);
            Thread myThread3 = new Thread(Sum);
            myThread3.Start(N);
            myThread3.Join();
            void Sum(object obj)
            {

                double sum = 0;
                if (obj is int n)
                {
                    for (int i = 0; i < n; i++)
                    {
                        sum += 1 / Math.Pow(2, i);
                        Console.WriteLine(sum.ToString());
                        
                    }
                }
            }
        }

    }
}
