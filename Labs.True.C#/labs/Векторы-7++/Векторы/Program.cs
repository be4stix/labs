using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Векторы
{
    class Program
    {
        static void Main(string[] args)
        {
            string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\Векторы-7+\Векторы\inlet.txt";
            string fout = @"C:\Users\Сергей\Desktop\Labs.True.C#\Векторы-7+\Векторы\outlet.txt";
            StreamWriter f = new StreamWriter(fout); 

            string[] arr = File.ReadAllLines(fin);
            int n = int.Parse(arr[0]);

            int[] fib = new int[100];
            fib[1] = 1;
            fib[2] = 1;
            for (int k = 3; k < n; k++)     //формируем последовательность Фиббоначчи
            {
                fib[k] = fib[k - 1] + fib[k - 2];
            }
            
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    if (i == fib[k] && i != 0)
                    {
                        f.Write(arr[i].ToString()+ ' ');  
                    }
                }
            }
            f.Close();
            
        }
    }
}
