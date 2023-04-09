using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {

            string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\lab14+\lab14\inlet.txt";
            string fout = @"C:\Users\Сергей\Desktop\Labs.True.C#\lab14+\lab14\outlet.txt";

            StreamWriter outlet = new StreamWriter(fout);

            Stack<int> SAO = new Stack<int> { };
            

            string[] str = File.ReadAllLines(fin);

            for (int i = 0; i < str.Length; i++)
            {
                SAO.Push(int.Parse(str[i]));
            }

            int min = SAO.Min();

            outlet.WriteLine(min);
            for (int i = 0; i < str.Length; i++)
            { 
               if ( int.Parse(str[i]) == SAO.Min())
                {
                    outlet.WriteLine(i + 1);
                }
            }

            outlet.Close();
            }
    }
}
