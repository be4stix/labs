#include <iostream>
#include <fstream>
#include <cmath>
#include <string>
#include<set>
#include <list>
using namespace std;
int main()
{
	int i=0, u=0, N ;
	string s;
	int a[50][50]{};
	set<int> z;
	set<int> f;
	set<int> sum;
	list<int> result;
	list<int>::iterator k;
	ifstream f1("Inlet.txt");
	ofstream f2("Outlet.txt");
	 
	f1 >> N;
	for (u = 0; u < N; u++){
	for (i = 0; i < N; i++) {
		
			f1>> a[u][i];
			if (a[u][i] <= 127 && a[u][i] >= -127 && i==u)
			{
				z.insert(a[u][i]);
			}
			else if (a[u][i] <= 127 && a[u][i] >= -127 && N==i+u+1) 
			{
				f.insert(a[u][i]);
			}
		}
	}

 	sum.insert(z.begin(), z.end());
	sum.insert(f.begin(), f.end());
 
	set <int> ::iterator t = z.begin();
	for (t = sum.begin(); t != sum.end(); t++)
	{
		result.push_front(*t);
	}
	
	for (k = result.begin(); k!=result.end(); k++) {
		f2 << *k << ' ';
	}

	f1.close();
	f2.close();
	return 0;
}