using System;
using System.Collections.Generic;


namespace CodeforcesSolutions
{
    internal class DownloadMoreRamSolution
    {
        public static void Main(string[] args)
        {
            LinkedList<int> output = new LinkedList<int>();

            int tests = int.Parse(Console.ReadLine());

            for (int t = 0; t < tests; ++t)
            {
                string[] nk = Console.ReadLine().Split();

                int n = int.Parse(nk[0]);
                int k = int.Parse(nk[1]);

                int[] array1 = new int[n];
                int[] array2 = new int[n];

                string[] softwareRamUsage = Console.ReadLine().Split();
                string[] softwareRamValue = Console.ReadLine().Split();

                for (int i = 0; i < n; ++i)
                {
                    array1[i] = int.Parse(softwareRamUsage[i]);
                    array2[i] = int.Parse(softwareRamValue[i]);
                }

                Array.Sort(array1, array2);

                for (int i = 0; i < n; ++i)
                {
                    if (array1[i] <= k)
                        k += array2[i];

                    else break;
                }

                output.AddLast(k);
            }

            foreach (var i in output)
                Console.WriteLine(i);
        }
    }
}
