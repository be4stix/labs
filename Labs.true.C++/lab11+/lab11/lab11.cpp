
#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main()
{
	string word;
	char  simvol;
	int i=0,k=0,f=0;

	ifstream fin("inlet.txt");
	ofstream fout("outlet.txt");

	fin >> simvol;
	
	while (!fin.eof())
	{
		fin >> word;
		if (word[0] == simvol)
		{
			k++;
		}
	}
	fout << k;

	fin.close();
	fout.close();
	return 0;
}

