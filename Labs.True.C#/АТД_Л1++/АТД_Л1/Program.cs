using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace АТД_Л1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\АТД_Л1+\АТД_Л1\inlet.txt";
            string fout = @"C:\Users\Сергей\Desktop\Labs.True.C#\АТД_Л1+\АТД_Л1\outlet.txt";
            StreamWriter output = new StreamWriter(fout);

            string[] str = File.ReadAllLines(fin);
             
            
            int k = int.Parse(str[0]);

            List<int> list = new List<int> { };
            for (int i = 1; i < str.Length;i++)
            {
                string[] strm = str[i].Split();
                for (int f = 0; f < strm.Length; f++)
                {
                    list.Add(int.Parse(strm[f]));
                }

            }

            for (int i = 0; i < list.Count;i++)
            {
                for (int f = 0; f <= k; f++)
                {
                    output.WriteLine(list[i]);
                }
            }
            output.Close();

        }
    }
}
