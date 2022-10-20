// 176848645  2022-10-18 11:04:20  Accepted-> 187ms 0kb
string[] input = Console.ReadLine().Split();
ulong n = ulong.Parse(input[0]);
ulong m = ulong.Parse(input[1]);
ulong a = ulong.Parse(input[2]);

ulong res;

res = (n % a == 0) ? n / a : n / a + 1;
res *= (m % a == 0) ? m / a : m / a + 1;

Console.Write(res);
