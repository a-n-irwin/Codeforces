// 177125048  2022-10-20 15:11:37  Accepted -> 61ms 488kb
int T = int.Parse(Console.ReadLine());
int[] output = new int[T];

for (int t = 0; t < T; ++t)
{
    int n = int.Parse(Console.ReadLine());
    string[] input = Console.ReadLine().Split();
    
    int min = int.MaxValue;    // minimum thickness
    
    for (int i = 0; i < input.Length; ++i)
    {
        int sum = 0;    // the target sum
        int segSum = 0; // segment sum
        int max = 0;  // maximum length of a segment
        int count = 0;  // the length of a segment when we arrive at the target sum
        for (int j = 0; j < input.Length; ++j)
        {
            // do sum up to the ith element
            if (j <= i) 
            {
                sum += int.Parse(input[j]);
                if (j == i) max = i+1;
            }
            else
            {
                segSum += int.Parse(input[j]);
                ++count;
                
                if (segSum == sum)
                {
                    max = Math.Max(max, count);
                    segSum = count = 0;
                }
                else if (segSum > sum || j == input.Length-1)
                {
                    max = min;
                    break;
                }
            }
        }
        min = Math.Min(min, max);
        if (i+2 >= min) break;
    }
    output[t] = min != int.MaxValue? min : input.Length;
}

foreach (int i in output) Console.WriteLine(i);
