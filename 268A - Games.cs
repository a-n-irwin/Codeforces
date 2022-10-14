int n = int.Parse(Console.ReadLine());
int[,] colors = new int[n,2];

int sum = 0;

for (int i = 0; i < n; ++i)
{
    string[] input = Console.ReadLine().Split();
    
    colors[i,0] = int.Parse(input[0]);
    colors[i,1] = int.Parse(input[1]);
}

// for each team
for (int i = 0; i < n; ++i)
{
    // for each other team
    for (int j = 0; j < n; ++j)
    {
        if (j != i && colors[j,1] == colors[i,0]) ++sum;
    }
}

Console.WriteLine(sum);
