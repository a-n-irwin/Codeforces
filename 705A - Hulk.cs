using System.Text;

var n = int.Parse(Console.ReadLine());
StringBuilder str = new StringBuilder(100);

for (int i = 1; i <= n; ++i)
{
	str.Append(i%2 != 0? "I hate" : "I love");
	str.Append(i != n? " that " : " it");
}

Console.Write(str);
