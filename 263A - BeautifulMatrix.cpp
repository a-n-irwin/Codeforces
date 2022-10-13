#include <iostream>
#include <array>

int main()
{
	std::array<std::array<int,5>,5> array;
	
	int r,c;
	
	for (int i = 0; i < array.size(); ++i)
	{
		for (int j = 0; j < array[i].size(); ++j)
		{
			std::cin >> array[i][j];
			if (array[i][j] == 1)
			{
				r = i; c = j;
			}
		}
	}
	
	std::cout << (std::abs(2-r)+std::abs(2-c));
}
