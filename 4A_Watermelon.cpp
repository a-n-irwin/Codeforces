#include <iostream>

int main()
{
    int w;

    std::cin >> w;
    std::cout << ((w > 3) && (!(w%2))? "YES" : "NO");
}
