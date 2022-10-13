#include <iostream>

int main()
{
	std::string a;
	std::string b;
	
	std::cin >> a >> b;
	
	for (std::size_t i = 0; i < a.length(); ++i)
	{
		a[i] = std::tolower(a[i]);
		b[i] = std::tolower(b[i]);
		
		if (a[i] < b[i])
		{
			std::cout << -1;
			return 0;
		}
		else if (a[i] > b[i])
		{
			std::cout << 1;
			return 0;
		}
	}
	
	std::cout << 0;
}
