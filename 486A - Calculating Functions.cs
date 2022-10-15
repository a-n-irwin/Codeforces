// 176380425  Oct. 15 2022 06:11PM  Stuck at "In queue"
// 176380425  Oct. xx 2022 
long n = long.Parse(Console.ReadLine());

long nNeg = (n%2 == 0)? n/2 : n/2 + 1;
long nPos = n-nNeg;

long neg = (nNeg*(-2*nNeg))/2;
long pos = (nPos*(2+2*nPos))/2;

Console.WriteLine(neg+pos);
