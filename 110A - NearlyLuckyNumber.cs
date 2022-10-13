string n = Console.ReadLine();
int count = 0;

foreach (var ch in n)
{
    if (ch == '4' || ch == '7')
        ++count;
}

Console.WriteLine((count == 4 || count == 7)? "YES" : "NO");
