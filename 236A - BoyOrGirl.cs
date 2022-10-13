string name = Console.ReadLine();

var uniqueChars = new HashSet<char>();

foreach (var ch in name)
{
    uniqueChars.Add(ch);
}

Console.WriteLine(uniqueChars.Count % 2 == 0? "CHAT WITH HER!" : "IGNORE HIM!");
