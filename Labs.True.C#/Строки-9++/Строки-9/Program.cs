using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Строки_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\Строки-9+\Строки-9\inlet.txt";
            string fout = @"C:\Users\Сергей\Desktop\Labs.True.C#\Строки-9+\Строки-9\outlet.txt";
            StreamWriter output = new StreamWriter(fout);
            
            string[] str = File.ReadAllLines(fin);

            for (int i = 0; i < str.Length; i++)
            {
                string[] strm = str[i].Split();
                for(int k = 0; k < strm.Length;k++)
                {
                    if (k % 2 != 0)
                    {
                        output.Write(strm[k]+' ');
                    }
                }
                output.WriteLine();
            }


            output.Close();
        }
    }
}

