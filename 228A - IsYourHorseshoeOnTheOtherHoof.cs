HashSet<int> colors = new HashSet<int>();

string[] input = Console.ReadLine().Split();

foreach (var i in input)
{
	colors.Add(int.Parse(i));
}

Console.WriteLine(input.Length-colors.Count);
