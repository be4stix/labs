#include <iostream>
#include <cmath>
using namespace std;

float main()

{
    float x, sl=1, n, k, tochnost, sum=0;
    cout << "Vvedite x: ";
    cin >> x;
    cout << "Vvedite tochnost: ";
    cin >> tochnost;
    n = 0;
    while (abs(sl) > tochnost)
    {
         
        k = (x - 1) / (x + 1);
        n = n + 1;
        sl = sl * (((2 * n + 1) / (2 * n + 3)) * pow(k,2));
        sum = sum + sl;
    }
    cout << "Summa " << sum;
}
