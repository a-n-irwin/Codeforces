// 177453850  Oct. 24 2022 16:26:35  Accepted -> 92ms 0kb
string s = Console.ReadLine();
Console.WriteLine(new System.Func<string>(() =>
{
    int count = 1;
    for (int i = 1; i < s.Length; ++i)
    {
        count = s[i] == s[i-1]? count+1 : 1;
        if (count == 7) return "YES";
    }
    return "NO";
})());
