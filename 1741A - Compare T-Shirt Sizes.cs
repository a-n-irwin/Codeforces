// 177206828  2022-10-20 19:25:36  Accepted -> 77ms 2436kb
int T = int.Parse(Console.ReadLine());
char[] output = new char[T];

Dictionary<char, int> d = new();
d['S'] = -1;
d['M'] = 0;
d['L'] = 1;

for (int t = 0; t < T; ++t)
{
    string[] sizes = Console.ReadLine().Split();
    
    int s1 = d[sizes[0][sizes[0].Length-1]]*sizes[0].Length;
    int s2 = d[sizes[1][sizes[1].Length-1]]*sizes[1].Length;
    
    output[t] = s1 > s2? '>' : (s1 < s2? '<' : '=');
}

foreach (char ch in output) Console.WriteLine(ch);
