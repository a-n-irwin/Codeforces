#include <iostream>
#include <vector>
#include <sstream>
#include <algorithm>

int main()
{
	std::string str;
	std::stringstream buffer;
	
	std::cin >> str;
	
	std::vector<char> v = {'a','e','i','o','u','y'};
	
	for (auto& ch : str)
	{
		ch = std::tolower(ch);
		if (std::find(v.begin(),v.end(),ch) == v.end())
		   buffer << "." << ch;
	}
	
	std::cout << buffer.str();
}
