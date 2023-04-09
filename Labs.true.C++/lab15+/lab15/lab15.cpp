#include <iostream>
#include <fstream>
#include <cmath>
#include <string>
#include <list>
using namespace std;
int a, i=0, kolvo=0, f=0;
string word[100]{};
int main()
{
    list<string> SAO;
    list<string>::iterator j;
    ifstream fin("Inlet.txt");
    ofstream fout("Outlet.txt");
    fin >> a;

    while (!fin.eof())
    {
        fin >> word[i];
        SAO.push_back(word[i]);
        i++;
        kolvo++;
    }
    for (i = 0;i < kolvo;i++)
    {
        if (a < size(word[i]))
        {
        f = 1;
        fout << word[i] << ' ' << i+1<<endl;
        }
    }
    if (f == 0)
    {
        fout << "No";
    }

    fin.close();
    fout.close();
    return 0;
}

 