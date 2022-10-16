// 176432363  Oct. 16 2022 08:59:04  Accepted -> 46ms 0kb
long n = long.Parse(Console.ReadLine());
Console.WriteLine(n%2 == 0? n/2 : -(n+1)/2);
