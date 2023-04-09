#include <iostream>
#include <fstream>
#include <string>
#include <cmath>
using namespace std;

int main()
{
	string word[100];
	int m=1;
	ifstream fin("input.txt");
	ofstream fout("output.txt");
	for (m = 0;m != 100;m++)
	{
		fin >> word[m];
		if (m % 2 != 0)
		{
			fout << word[m] << ' ';
		}
	}
	fin.close();
	fout.close();
	return 0;
}
