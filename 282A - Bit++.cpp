#include <iostream>

int main()
{
	int n,x = 0;
	std::string op;
	
	std::cin >> n;
	
	for (int i = 0; i < n; ++i)
	{
		std::cin >> op;
		(op[1] == '+')? ++x : --x;
	}
	
	std::cout << x;
}
