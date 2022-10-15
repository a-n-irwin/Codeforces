// 176303094  Oct 15 2022.  Accepted -> 93ms 0kb
HashSet<int> xyLevels = new();

int n = int.Parse(Console.ReadLine());

string[] x = Console.ReadLine().Split();
string[] y = Console.ReadLine().Split();

var push = delegate (string[] levels)
{
    for (int i = 1; i < levels.Length; ++i)
    {
        xyLevels.Add(int.Parse(levels[i]));
    }
};

push(x);
push(y);

Console.WriteLine(n == xyLevels.Count? "I become the guy." : "Oh, my keyboard!");
