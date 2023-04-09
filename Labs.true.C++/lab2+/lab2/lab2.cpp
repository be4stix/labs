
// lab2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>

int main()
{
    float a = 1, x, sum = 0;
    int k, i;
    std::cout << "Vvedite x ";
    std::cin >> x;
    std::cout << "Vvedite k ";
    std::cin >> k;
    for (i = 1;i <= k;i++)
    {
        a = a * x / (k + 1);
        sum = sum + a;
    }
    std::cout << "Pri k: " << k << "\n";
    std::cout << "Pri x: " << x << "\n";
    std::cout << "Summa: " << sum << "\n";


}
