int a=5,b=10;
/*
int temp=a;
a=b;
b=temp;
*/

a = a + b;
b = a - b;
a = a - b;
Console.WriteLine(a);
Console.WriteLine(b);