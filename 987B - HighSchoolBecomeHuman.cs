string[] input = Console.ReadLine().Split();

int x = int.Parse(input[0]);
int y = int.Parse(input[1]);

double logXy = y*(Math.Log10(x));
double logYx = x*(Math.Log10(y));

double diff = logXy-logYx;

Console.WriteLine(diff > 0? ">" : (diff < 0? "<" : "="));
