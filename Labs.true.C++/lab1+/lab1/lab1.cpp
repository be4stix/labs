#include <iostream>
#include <locale.h>
#include <cmath>
using namespace std;
double x, y = 0;
int main()
{



    cin >> x;
    if (-4 <= x && x < -2)
    {
        y = x / 2 + 1;
        cout << "y=" << y << endl;
    }
    else
    {
        if (-2 <= x && x < 0)
        {
            y = sqrt(4 - pow(x, 2));
            cout << "y=" << y << endl;
        }
        else
        {
            if (0 <= x && x < 2)
            {
                y = -x + 2;
                cout << "y=" << y << endl;
            }
            else
            {
                if (2 <= x && x < 4)
                {
                    y = pow(x, 2) - 6 * x + 7;
                    cout << "y=" << y << endl;
                }
                else
                {
                    if (4 <= x && x <= 5)
                    {
                        y = x - 4;
                        cout << "y=" << y << endl;
                    }
                    else
                        cout << "Takih znachenii net" << endl;
                }
            }
        }

    }
    return 0;

}
