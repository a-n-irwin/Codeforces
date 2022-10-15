// 176358145  Oct. 15 2022  Accepted -> 124ms 200kb
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

string[] input = Console.ReadLine().Split();

for (int i = 0; i < n; ++i)
{
    arr[int.Parse(input[i])-1] = i+1;
}

foreach (int i in arr) Console.Write($"{i} ");
