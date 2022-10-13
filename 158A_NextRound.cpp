#include <iostream>
#include <vector>

int main()
{
	int n,k,count = 0;
	std::cin >> n >> k;
	
	std::vector<int> scores(n);
	for (auto& e : scores) std::cin >> e;
	
	for (auto& e : scores)
	    if (e > 0 && e >= scores[k-1]) ++count;
	
	std::cout << count;
}
