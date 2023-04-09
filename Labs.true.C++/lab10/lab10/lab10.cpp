
#include <iostream>
#include <fstream>
#include <string>
using namespace std;

const int n = 100;
char d;
int i = 0, kolvo = 0,pp=0,t[100]{},o=0,z=0,pp=0,k=0,j=0;
string s,a,word[n]{};
 ifstream fin("Inlet.txt");
 ofstream fout("Outlet.txt");

void schitat()
{   
    if (!fin.eof())
    {
        fin.getline();
        pp++;
        schitat;
    }
}

void d1()
{
    if (i<=pp)
    {
        if (i=pp)  
        {
            fin>>d;
        }
        else 
        {
            fin.getline();
            d1;
        }
    }
}

void d2()
{
    if (j < size(s))
    {
        if(s[j]=' ')
        {
            o++;
            t[o] =j-1-z;
            z=j;
        }
        j++;
        d2;
    }
}

void d3()
{
    if (i<size(s)-t[o]-1)
    {
        if (s[j]==d)
        {
            k++;
            j++;
            d3;
        }
    }
}

void d4()
{
    if (i<pp-1)
    {
        fin >> s;
        j=1;
        d2;
        o++;
        t[o] = size(s)-z;
        j = size(s) - t[o] - t[o-1];
        d3;
        if (k!=0)
        {
            fout<<k;
            k=0;
        }
        else 
        {
            fout << '-1';
        }
        i++;
        d4;
    }   
}

int main()
{
    schitat;
    fin.reset();
    i=1;
    d1;
    fin.reset();
    i=1;
    d4;
    
    

    fin.close();
    fout.close();
    return 0;
}
