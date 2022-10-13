#include <iostream>

int main(int argc, char *argv[])
{
	std::string s;
	std::cin >> s;
	
	s[0] = std::toupper(s[0]);
	std::cout << s;
}
