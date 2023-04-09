#include <iostream>
#include <fstream>
#include <cmath>
#include <string>
#include <list>

using namespace std;
int main()
{
    list<int> SAO;
    list<int>::iterator j;
    int i=0, min=0, mesto=0, kolvo=0,f;
    int a[100]{};

    ifstream fin("Inlet.txt");
    ofstream fout("Outlet.txt");

    while (!fin.eof())
    {
        fin >> a[i];
        i++;
        kolvo++;
    }

    for (i = 0;i < kolvo;i++)
    {
        SAO.push_front(a[i]);
    }
        for (i = 0; i <kolvo; i++)
        {
            min = a[0];
            for (f = 1;f < kolvo;f++)
            {
                if (a[f] < min)
                {
                     min = a[f];
                mesto = f-1;
                }
            }
    }
        
        for (j = SAO.begin(); j != SAO.end(); j++) {
            fout << (*j)<<' ';
        }

        fout << endl;
    fout << min <<' '<< mesto;
    fin.close();
    fout.close();
    return 0;
}