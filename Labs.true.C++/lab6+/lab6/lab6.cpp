// lab3.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <cmath>
#include <fstream>
#include <string>
using namespace std;



float f(float x)
{
    x = x * x - sin(5 * x);
    return x;
}
float f1(float x)
{
    x = 2 * x - 5 * cos(5 * x);
    return x;
}
float f2(float x)
{
    x = 2 + 25 * sin(5 * x);
    return x;
}
float np(float a, float b)
{
    if (f(a) * f2(a) > 0)
    {
        return a;
    }
    else
    {
        return  b;
    }

}
float sk(float a, float b, float tochnost, float x)
{
    if (abs(f(x)) > tochnost)
    {
        return sk(a, b, tochnost, x - f(x) / f1(x));
    }
    else
    { 
    return  x;
    }
}

float rec(float a, float b, float tochnost, float x)
{
    if (x-sk(a,b,tochnost,x)>tochnost)
    {
        return rec(a, b, tochnost, x - f(x) / f1(x));
    }
    else
    {
        return  x;
    }
}

float main()
{
    float x, a, b,k, tochnost, koren;
    ifstream fin("input.txt");
    ofstream fout("output.txt");
    fin >> a >> b >> tochnost; 
    k= rec(a, b, tochnost, np(a, b));
    fout << k;
    fin.close();
    fout.close();

    return 0;
}
