#include <iostream>
#include <fstream>
int kelx, kely, s, i, summ, k = 0, a[100];
    float sz, znach;
using namespace std;
int main()
{
    

    ifstream fin("input.txt");
    ofstream fout("outlet.txt");
    fin >> kelx >> kely >> znach;
   

    for (s = 0;s < kely;s++)
    {
        summ = 0;
        sz = 0;
        i = 0;
        for (i = 0;i < kelx;i++)
        {
            fin >> a[i];
            summ = summ + a[i];
        }
        sz = summ / kelx;
        if (sz < znach)  k = k + 1;
    }
    fout << k;

    fin.close();
    fout.close();
    return 0;
}
