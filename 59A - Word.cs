using System.Text;


LinkedList<int> lower = new LinkedList<int>();
LinkedList<int> upper = new LinkedList<int>();

var s = new StringBuilder(Console.ReadLine());


for (int i = 0; i < s.Length; ++i)
{
	if (s[i] < 'a') upper.AddLast(i);
	else
		lower.AddLast(i);
}

if (upper.Count > lower.Count)
	foreach (var i in lower)
		s[i] = (char)(s[i]-32);
else
	foreach (var i in upper)
		s[i] = (char)(s[i]+32);


Console.WriteLine(s);
