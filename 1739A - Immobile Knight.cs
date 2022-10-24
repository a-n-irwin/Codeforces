// 177453850  Oct. 24 2022 17:17:40  Accepted -> 46ms 0kb
int T = int.Parse(Console.ReadLine());
int[,] output = new int[T, 2];

for (int t = 0; t < T; ++t)
{
    string[] input = Console.ReadLine().Split();
    int n = int.Parse(input[0]);
    int m = int.Parse(input[1]);

    if ((n > 3 && m > 1) || (m > 3 && n > 1) || (m == 1 || n == 1))
    {
        output[t, 0] = n;
        output[t, 1] = m;
    }
    else if (n*m == 9 || n*m == 6 || n*m == 4)
        output[t, 0] = output[t, 1] = 2;
    else
        output[t, 0] = output[t, 1] = 1;
}

for (int i = 0; i < T; ++i) Console.WriteLine("{0} {1}", output[i, 0], output[i, 1]);
