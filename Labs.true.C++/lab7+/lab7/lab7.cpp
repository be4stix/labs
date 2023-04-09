#include <iostream>
#include <cmath>
#include <fstream>
using namespace std;

int main()
{
	int k,p,i,f=0,g=1;
	int a[100]{}, b[100]{};
	ifstream fin("input.txt");
	ofstream fout("output.txt");

	fin >> p;
	
	b[0] = 1;
	b[1] = 1;
	for (k = 2;k < p;k++)
	{
		b[k] = b[k - 1] + b[k - 2];	
	}

	for (i = 0;i < p;i++)
	{
		fin >> a[i];	
	}

	for (i = 0;i <= p;i++)
	{
		for (k = 0; k <= p; k++)
		{
			if ((i == b[k]) && (i != 0))
			{
				fout << a[i-1] << " ";
			}
		}
	}

	fin.close();
	fout.close();

	return 0;
}
