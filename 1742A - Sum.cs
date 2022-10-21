// 177273598  2022-10-21 10:35:49  Accepted -> 62ms 1736 KB
int T = int.Parse(Console.ReadLine());
string[] output = new string[T];

for (int t = 0; t < T; ++t)
{
    string[] abc = Console.ReadLine().Split();
    
    int a = int.Parse(abc[0]);
    int b = int.Parse(abc[1]);
    int c = int.Parse(abc[2]);
    
    output[t] = a+b+c == 2*Math.Max(Math.Max(a, b), c)? "Yes" : "No";
}

foreach (string s in output) Console.WriteLine(s);
