var x = int.Parse(Console.ReadLine());

var steps = x/5;
var rem = x%5 == 0;

Console.WriteLine(steps > 0? steps+(rem? 0 : 1) : 1);
