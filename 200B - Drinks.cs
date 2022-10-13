using System;


namespace CodeforcesSolutions
{
    internal class DrinksSolution
    {
        public static void Main()
        {
            double pureTotal = 0;
            int n = Convert.ToInt32(Console.ReadLine());

            string[] percent = Console.ReadLine().Split();

            for (int i = 0; i < n; ++i)
                pureTotal += Convert.ToDouble(percent[i]);

            Console.WriteLine(pureTotal / n);
        }
    }
}
