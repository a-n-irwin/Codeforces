// 176286411  Oct 15 2022.  Accepted -> 46ms 0kb
HashSet<int> xyLevels = new();

int n = int.Parse(Console.ReadLine());

string[] x = Console.ReadLine().Split();
string[] y = Console.ReadLine().Split();

int dup = 0;

var push = delegate (string[] levels)
{
    for (int i = 1; i < levels.Length; ++i)
    {
        if (!xyLevels.Add(int.Parse(levels[i]))) ++dup;
    }
};

push(x);
push(y);

Console.WriteLine(n == (x.Length-1)+(y.Length-1)-dup? "I become the guy." : "Oh, my keyboard!");
