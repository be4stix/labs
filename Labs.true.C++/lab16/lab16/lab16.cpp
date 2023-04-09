#include <iostream>
#include <fstream>
#include <cmath>
#include <string>
#include <deque>

using namespace std;


int main()
{

    int const n = 400;
    deque <char> dec;
    deque <char>::iterator j;
    int i = 0, f = 0, k = 0, kolvo = 0, kolvo2 = 0,result=0;
    char a[n];
    string str;

    ifstream fin("Inlet.txt");
    ofstream fout("Outlet.txt");


    while (!fin.eof())
    {
        getline(fin,str);
        kolvo++;
    }
    for (i = 0;i < kolvo;i++)
    {
        for (k = 0;k <= size(str); k++)
        {
          a[k]= str[k];
          kolvo2++;
          //fout << a[k];
        }
      
    }
    f = size(str);
    if (kolvo2 / 2 == 0)
    {
        for (i = 0;i < kolvo;i++)
        {
            for (k = 0;k < f; k++, f--)
            {
                dec.push_front(a[k]);
                dec.push_back(a[f]);
            }
        }
    }
    else {
        for (i = 0;i < kolvo;i++)
        {
            for (k = 0;k < f; k++, f--)
            {
                dec.push_front(a[k]);
                dec.push_back(a[f-1]);
            }
        }
    }
   
    for (j = dec.begin();j < dec.end();j++)
    {
        fout << *j;
    }

    //fout << endl;

    for (j = dec.begin()+1;j < dec.end()-1;j++)
    {   
        //fout << *j;
        if (*j == ' ')
        {
            result++;
        }
    }
    fout << endl;
    fout << result+1;


    fin.close();
    fout.close();
    return 0;
}