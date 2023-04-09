using System;
using System.Collections.Generic;

namespace LabASD3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> List = new List<double>();

            Random rand = new Random();

            int n = 10;
            for (int i = 0; i < n; i++)
            {
                List.Add(rand.NextDouble()*100);
            }
            foreach(double s in List)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine(SumList(List));

            double SumList(List<double> list)
            {
                if (list.Count != 0)
                {
                    double sum = 0;
                    foreach (double s in list)
                    {
                        sum += s;
                    }
                    return sum / list.Count;
                }
                else
                {
                    Console.WriteLine("Список пуст");
                }
                return 0;
            }
        }
        
    }
}
