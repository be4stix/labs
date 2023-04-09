using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

using System.IO;

namespace lab13
{
	class Program
	{
		static void Main(string[] args)
		{
			string fin = @"C:\Users\Сергей\Desktop\лабы\lab14\lab14\inlet.txt";
			string fout = @"C:\Users\Сергей\Desktop\лабы\lab14\lab14\outlet.txt";

			StreamWriter outlet = new StreamWriter(fout);

			string[] str = File.ReadAllLines(fin);
			float[] array = new float[] { };
			Stack<float> stack = new Stack<float>();

			for (int i = 0; i < str.Length; i++)
			{
				string[] strm = str[i].Split();
				for (int k = 0; k < strm.Length; k++)
				{
					stack.Push(float.Parse(strm[k])); ;
				}
			}

			string[] strm2 = str[0].Split();
			int min = int.Parse(strm2[0]);
 
			foreach( float elem in stack)
            {
				if (elem >= 0.9 * min && elem <= 1.1 * min)
                {
					outlet.Write(elem.ToString() + " ");
                }


			}






			outlet.Close();

		}
	}
}
