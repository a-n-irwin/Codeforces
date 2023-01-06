// 188177269  Jan. 6 2023 08:10:06  Accepted -> 92ms 240kb
int[] axes = {0, 0, 0};
int n = int.Parse(Console.ReadLine());

while (--n >= 0)
{
    string[] input = Console.ReadLine().Split();
    
    axes[0] += int.Parse(input[0]);
    axes[1] += int.Parse(input[1]);
    axes[2] += int.Parse(input[2]);
}

Console.WriteLine(Math.Abs(axes[0]) + Math.Abs(axes[1]) + Math.Abs(axes[2]) == 0? "YES" : "NO"); 
