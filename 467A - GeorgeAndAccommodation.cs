int n = int.Parse(Console.ReadLine());

int output = 0;


while (--n >= 0)
{
	string[] input = Console.ReadLine().Split();
	
	int occupants = int.Parse(input[0]);
	int capacity = int.Parse(input[1]);
	
	if (capacity-occupants >= 2)
	    ++output;
}

Console.Write(output);
