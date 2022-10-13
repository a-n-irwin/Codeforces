Console.ReadLine();
string input = Console.ReadLine();

int count = 0;
foreach (var i in input)
{
	if (i == 'A')
		++count;
	else 
		--count;
}

Console.WriteLine(count > 0? "Anton" : (count == 0? "Friendship" : "Danik"));
