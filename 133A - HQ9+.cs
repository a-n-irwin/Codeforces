// 188197400  Jan. 5 2023 11:20:45  Accepted -> 92ms 0kb
string p = Console.ReadLine();
bool res = false;

foreach (char ch in p)
{
    if (ch == 'H' || ch == 'Q' || ch == '9')
    {
        res = true;
        break;
    }
}

Console.WriteLine(res? "YES" : "NO");
