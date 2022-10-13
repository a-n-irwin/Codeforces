var input = Console.ReadLine().Split();

int k = int.Parse(input[0]);
int n = int.Parse(input[1]);
int w = int.Parse(input[2]);

double cost = (w/2.0)*(k + (k+(w-1)*k));

Console.Write(cost > n? cost-n : 0);
