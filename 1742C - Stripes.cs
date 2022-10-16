// 176457546  Oct. 16 2022 11:43:24  Accepted-> 77ms 1100kb
int t = int.Parse(Console.ReadLine());
char[] results = new char[t];

for (int i = 0; i < t; ++i)
{
    char stripe = 'B';
    Console.ReadLine(); // For the empty line
    for (int j = 0; j < 8; ++j)
    {
        string line = Console.ReadLine();
        if (stripe == 'B')
        {
            stripe = (line == "RRRRRRRR")? 'R' : 'B';
        }
    }
    results[i] = stripe;
}
foreach (char ch in results) Console.WriteLine(ch);
