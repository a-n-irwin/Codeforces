string[] input = Console.ReadLine().Split();
int h = int.Parse(input[1]);
int w = 0;

input = Console.ReadLine().Split();

foreach (string a in input)
{
    w += (int.Parse(a) > h)? 2 : 1;
}

Console.WriteLine(w);
