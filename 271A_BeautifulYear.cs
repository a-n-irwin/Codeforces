int year = int.Parse(Console.ReadLine())+1;
var IsDistinct = delegate (string str)
{
    // for each char
    for (int i = 0; i < str.Length; ++i)
    {
        // check for other instances
        for (int j = 0; j < str.Length; ++j)
        {
            if (j != i && str[j] == str[i])
                return false;
        }
    }
    return true;
};

for (; !IsDistinct(year.ToString()); ++year);
Console.WriteLine(year);
