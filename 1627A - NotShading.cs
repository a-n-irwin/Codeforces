using System;
using System.Collections.Generic;

namespace CodeforcesSolutions
{
    class NotShading
    {
        static void Main(string[] args)
        {
            LinkedList<int> output = new LinkedList<int>();

            int tests = int.Parse(Console.ReadLine());

            for (int t = 0; t < tests; ++t)
            {
                int noBCount = 0;
                string[] input = Console.ReadLine().Split();

                int n = int.Parse(input[0]);

                int r = int.Parse(input[2]) - 1;
                int c = int.Parse(input[3]) - 1;

                string[] rowString = new string[n];

                for (int i = 0; i < n; ++i)
                {
                    rowString[i] = Console.ReadLine();

                    if (!rowString[i].Contains("B"))
                        ++noBCount;
                }

                if (noBCount == rowString.Length)
                    output.AddLast(-1);
                else if (rowString[r][c] == 'B')
                    output.AddLast(0);
                else if (rowString[r].Contains("B"))
                    output.AddLast(1);
                else
                {
                    for (int row = 0; row < rowString.Length; ++row)
                    {
                        if (rowString[row][c] == 'B')
                        {
                            output.AddLast(1);
                            break;
                        }
                        else if (row == rowString.Length - 1)
                            output.AddLast(2);
                    }
                }
            }

            foreach (var i in output)
                Console.WriteLine(i);
        }
    }
}
