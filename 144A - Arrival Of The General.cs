// 177433561  Oct. 22 2022 13:45:00  Accepted -> 124ms 100kb
int n = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split();

int min, minI;
int max, maxI;

min = max = int.Parse(input[0]);
minI = maxI = 0;

for (int i = 1; i < n; ++i)
{
    int val = int.Parse(input[i]);
    
    if (min >= val) // greater or equal, so we have the minimum nearest to the rear
    {
        min = val;
        minI = i;
    }
    
    if (max < val)  // strictly less, so we have the maximum nearest to the front
    {
        max = val;
        maxI = i;
    }
}

Console.WriteLine(maxI + (n - minI - 1) - (minI < maxI? 1 : 0));
