// 188184555  Jan. 06 2023 09:19:36  Accepted -> 93ms 560kb
int t = int.Parse(Console.ReadLine());
int[] output = new int[t];

for (int i = 0; i < t; ++i)
{
    int n = int.Parse(Console.ReadLine());
    output[i] = (n == 1 || n == 2)? 0 : ((n%2 == 0)? n/2 - 1 : n/2);
}

foreach (int i in output) 
    Console.WriteLine(i);
