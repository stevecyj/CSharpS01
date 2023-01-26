int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

int max = a, min = a;
if (max < b)
{
    max = b;
}

if (max < c)
{
    max = c;
}

if (max < d)
{
    max = d;
}

if (min > b)
{
    min = b;
}

if (min > c)
{
    min = c;
}

if (min > d)
{
    min = d;
}

Console.WriteLine("最大值是{0}，最小值是{1}", max, min);