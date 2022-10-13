#include <iostream>
#include <vector>

int main()
{
    std::size_t n;
    std::cin >> n;

    std::vector<std::string> words(n);

    for (auto& word : words)
    {
        std::cin >> word;

        if (word.length() > 10)
            word = word[0]+std::to_string(word.length()-2)+word[word.length()-1];
    }

    for (auto& word : words)
        std::cout << word << std::endl;
}
