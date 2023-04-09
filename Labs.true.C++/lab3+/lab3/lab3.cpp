#include <iostream>
#include <cmath>
using namespace std;

float x, a, b, tochnost, koren;

    float f(float x)
    {
        x = cos(2 / x) - 2 * sin(1 / x) + 1 / x;
        return x;
    }
    float f1(float x)
    {
        x = 1 / (x * x) * (2 * cos(1 / x) + 2 * sin(2 / x) - 1);
        return x;
    }
    float np(float a, float b)
    {
        if (f(a) * f1(a) > 0)
        {
            return a;
        }
        else
        {
            return  b;
        }
        
    }
    float reshenie(float a, float  b, float tochnost)
    {
        x = np(a, b);
        while (abs(f(x)) > tochnost) 
        {
           return x - f(x) / f1(np(a, b));
        }
      
    }
    int main()
    {
    cout << "Vvedite a: ";
    cin >> a;
    cout << "Vvedute b: ";
    cin >> b;
    cout << "Vvedite tochnost: ";
    cin >> tochnost;
    koren = reshenie(a, b, tochnost);
    cout << "Reshenie " << koren;

    return 0;
}
