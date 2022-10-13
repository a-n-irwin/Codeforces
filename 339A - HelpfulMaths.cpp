#include <iostream>
#include <queue>
#include <vector>

int main()
{
	std::string sum;
	std::cin >> sum;
	
	std::priority_queue<char,std::vector<char>,std::greater<char>> q;
	
	for (auto& e : sum)
	    if (std::isdigit(e)) q.push(e);
	    
	while (!q.empty())
	{
	    std::cout << q.top();
	    q.pop();
	    if (!q.empty()) std::cout << "+";
	}
}
