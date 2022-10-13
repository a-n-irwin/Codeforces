var input = Console.ReadLine().Split();

int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

int years = 0;

for (; a <= b; ++years)
{
	a *= 3;
	b *= 2;
}

Console.WriteLine(years);
