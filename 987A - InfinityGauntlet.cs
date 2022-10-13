var stones = new Dictionary<string,string>();
stones.Add("purple","Power");
stones.Add("green","Time");
stones.Add("blue","Space");
stones.Add("orange","Soul");
stones.Add("red","Reality");
stones.Add("yellow","Mind");

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; ++i)
{
	string color = Console.ReadLine();
	stones.Remove(color);
}

Console.WriteLine(stones.Count);
foreach (var s in stones)
{
	Console.WriteLine(s.Value);
}
