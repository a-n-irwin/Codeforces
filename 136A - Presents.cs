// 176340428  Oct. 15 2022  Accepted -> 124ms 300kb

// Keys are receivers, Values are givers
Dictionary<int, int> d = new();

int n = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split();

int index = 1;
foreach (string i in input)
{
    d[int.Parse(i)] = index++;
}

for (index = 1; index <= n; ++index)
{
    Console.Write($"{d[index]} ");
}
