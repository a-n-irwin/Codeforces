var mySet = new HashSet<int>();

int[] array = new int[4];

array[0] = int.Parse(Console.ReadLine());
array[1] = int.Parse(Console.ReadLine());
array[2] = int.Parse(Console.ReadLine());
array[3] = int.Parse(Console.ReadLine());

int d = int.Parse(Console.ReadLine());
var min = array[0];

if ((array.Contains(1)? d : 0) == 0)
{
    foreach (var nth in array)
    {
        if (min > nth) min = nth;
        for (int i = nth; i <= d; i += nth)
        {
            mySet.Add(i);
        }
    }
}

if (min > d)
{
    Console.WriteLine(0);
    return;
}
Console.WriteLine(mySet.Count > 0 ? mySet.Count : d);
