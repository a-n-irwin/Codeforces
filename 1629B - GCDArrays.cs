using System;
using System.Collections.Generic;


namespace CodeforcesSolutions
{
    internal class GreatestCommonDivisorArrays
    {
        public static void Main(string[] args)
        {
            LinkedList<string> output = new LinkedList<string>();

            int tests = int.Parse(Console.ReadLine());

            for (int i = 0; i < tests; ++i)
            {
                string[] input = Console.ReadLine().Split();

                int l = int.Parse(input[0]);
                int r = int.Parse(input[1]);
                int k = int.Parse(input[2]);

                int length = r - l + 1;

                if (l == r)
                    output.AddLast(l > 1 ? "YES" : "NO");
                else
                {
                    // if length is even, there are equal number of odd and even numbers
                    if ((length%2) == 0)
                    {
                        output.AddLast(k >= (length / 2) ? "YES" : "NO");
                    } 
                    else
                    {
                        if ((l % 2) == 0)
                            output.AddLast(k >= (length / 2) ? "YES" : "NO");
                        else
                            output.AddLast(k >= (int)Math.Ceiling(length / 2.0) ? "YES" : "NO");
                    }
                }
            }

            foreach (var i in output)
                Console.WriteLine(i);
        }
    }
}
