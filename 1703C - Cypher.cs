using System;
using System.Text;


static class Program
{
	static void Main(string[] args)
	{
		int t = int.Parse(Console.ReadLine());
		StringBuilder[] output = new StringBuilder[t];
		
		for (int k = 0; k < t; ++k)
		{
			int n = int.Parse(Console.ReadLine());
			string[] faceValue = Console.ReadLine().Split();
			
			output[k] = new StringBuilder(2*n);
			
			for (int i = 0; i < n; ++i)
			{
				string[] movesCombo = Console.ReadLine().Split();
				
				int value = int.Parse(faceValue[i]);
				foreach (var ch in movesCombo[1])
				{
					value = (ch == 'U')? value-1 : value+1;
					if (value > 9) value = 0;
					if (value < 0) value = 9;
				}
				output[k].Append(value + " ");
			}
		}
		
		foreach (var i in output)
			Console.WriteLine(i);
	}
}
