using System.Text;


string ber = Console.ReadLine();
string bir = Console.ReadLine();

StringBuilder sb = new(bir.Length);

for (int i = 0; i < sb.Capacity; i++)
    sb.Append(bir[bir.Length-1-i]);
    
Console.WriteLine(ber == sb.ToString()? "YES" : "NO");
