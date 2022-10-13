using System.Text;


int n = int.Parse(Console.ReadLine());
StringBuilder filter = new(n);


string stones = Console.ReadLine();
char prev = '\0';

foreach (var ch in stones)
{
	if (ch != prev)
	{
		filter.Append(ch);
		prev = ch;
	}
}

Console.Write(stones.Length-filter.Length);
