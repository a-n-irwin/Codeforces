int n = int.Parse(Console.ReadLine());

int groups = 1;

// pattern to query
string query = Console.ReadLine();
string input;

for (int i = 1; i < n; ++i)
{
	input = Console.ReadLine();
	if (input != query)
	{
		++groups;
		query = input;
	}
}

Console.WriteLine(groups);
