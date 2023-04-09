using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;щ
using System.Threading.Tasks;
 
using System.Collections;
 
using System.IO;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
			string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\lab13+\lab13\inlet.txt";
			string fout = @"C:\Users\Сергей\Desktop\Labs.True.C#\lab13+\lab13\outlet.txt";

			StreamWriter outlet = new StreamWriter(fout);

			int N;
			 
			string[] str = File.ReadAllLines(fin);

			N = int.Parse(str[0]);

            int[,] a = new int[N,N];

			HashSet<int> z = new HashSet<int>();
			HashSet<int> f = new HashSet<int>();

			for (int u = 0; u < N; u++)
			{
				string[] strm = str[u+1].Split();
				for (int i = 0; i < N ; i++)
				{
                    a[u,i] = int.Parse(strm[i]);
                }
			}

			for (int u = 0; u < N; u++)
            {
				for (int i = 0; i < N; i++)	
				{
					if ( a[u, i] > 127 || a[u, i] < -127)
					{
						Environment.Exit(0);
					}
					else if ( i + u + 1 == N)
					{
						f.Add(a[u, i]);
					}
					else if (i == u)
					{	
						z.Add(a[u, i]);
					}
				}
                }

			IEnumerable<int> sum = z.Union(f);
			var result = sum.OrderByDescending(s => s);

			foreach (int s in result)
            {
				outlet.Write(s.ToString()+" ");
            }
		 

			outlet.Close();
 
		}
    }
}
