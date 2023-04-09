#include <iostream>
#include <list>
#include <fstream>
#include <string>
#include <math.h>
using namespace std;

int m=0,mf,i,aa,d[100];
float u;
string g;

int main()
{
    ifstream fin("inlet.txt");
    ofstream fout("outlet.txt");
    list<int> spisok;
    list<int>::iterator j;

    fin >> m;

    mf = 1;
    for (int i = 1; i <= m; i++)
    {
        mf = mf * i;
    }

    g = to_string(mf);
    u = pow(10, size(g) - 1);

    for (int i = 0; i < size(g); ++i)
    {
        d[i] = mf / u;
        mf = mf - d[i] * u;
        if (u > 2)
        {
            u = u / 10;
        }
    }
    
    for (i=0; i<size(g);i++)
    {
    	spisok.push_back(d[i]);
    }


   	for (j = spisok.begin();j != spisok.end();j++)
   	{
   		fout << (*j)<< ' ';
   	}
    fin.close();
    fout.close();
    return 0; 
}