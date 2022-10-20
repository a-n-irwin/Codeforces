// 177090918  Oct. 20 2022 09:57:34  Accepted -> 61ms 6420kb
using System.Text;

int T = int.Parse(Console.ReadLine());
StringBuilder[] b = new StringBuilder[T];

for (int i = 0; i < T; ++i)
{
    int n = int.Parse(Console.ReadLine());
    
    string line = Console.ReadLine();
    string[] input = line.Split();
    
    b[i] = new StringBuilder(line.Length);
    
    for (int j = 1; j < input.Length; j += 2)
    {
        b[i].Append($"{-int.Parse(input[j])} {int.Parse(input[j-1])} ");
    }
}
foreach (var s in b) Console.WriteLine(s);
