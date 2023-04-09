
#include <iostream>
#include <cmath>
using namespace std;

float main()
{
	float x, tochnost;
	int k, n;
   cout << "Vvedite x: ";
   cin >> x;
   cout << "Vvedite k: ";
   cin >> k;
   cout << "Vvedite tochnost: ";
   cin >> tochnost;
  float slag =1 ,sum=0,a=0;
   for (n = 1; n<k; n++)
   {
	   a = slag;
	   slag = x * slag / (n + 1);
	   if (abs(a-slag) > tochnost)
	   {
		   sum = sum + slag;
		  
	   }
	   else {
		   break;
	   }

   }
   if (n < k)
   {
	   cout << "n= " << n << " sum " << sum;
   }
   else
   {
	   cout << "k= " << k << "sum " << sum;
   }
   return 0;

}