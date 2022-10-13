int n = int.Parse(Console.ReadLine());
int capacity = 0;
int total = 0;

for (int i = 0; i < n; ++i)
{
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    
    total = total-a+b;
    capacity = Math.Max(capacity, total);
}

Console.WriteLine(capacity);
