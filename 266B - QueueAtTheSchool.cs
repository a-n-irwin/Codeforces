using System.Text;


string[] input = Console.ReadLine().Split();
string line = Console.ReadLine();

StringBuilder sb = new StringBuilder(line);

int t = int.Parse(input[1]);

for (int i = 0; i < t; ++i)
{
    for (int j = 0; j < sb.Length-1; j++)
    {
        // If a boy is in front of a girl, swap
        if (sb[j] == 'B' && sb[j+1] == 'G')
        {
            char temp = sb[j];
            sb[j] = sb[j+1];
            sb[j+1] = temp;
            j++; // Shift
        }
    }
}

Console.WriteLine(sb);
