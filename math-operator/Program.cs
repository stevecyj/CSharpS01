/*
int a = 23 + 23;
int b = 2 - 10;
int c = 4 * 23;
int d = 45 / 10;
int e = 45 % 10;
double f = 45 / 10.0;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
*/

int num = 39;
int unitDigit = num % 10;
int tensDigit = num / 10;
Console.WriteLine("個位數是{0},十位數是{1}", unitDigit, tensDigit);