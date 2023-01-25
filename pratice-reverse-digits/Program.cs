/*int number = Convert.ToInt32(Console.ReadLine());
int unitDigit = number % 10;
int tensDigit = number / 10 % 10;
int hundredsDigit = number / 100;
Console.WriteLine("" + unitDigit + tensDigit + hundredsDigit);*/

/*int num = Convert.ToInt32(Console.ReadLine());
int tensDigit = num / 10 % 10;
int thousandsDigit = num / 1000 % 10;
int numNew = thousandsDigit * 10 + tensDigit;
char c=(char)numNew;
Console.WriteLine(c);*/

/*
int a=3;
int b=a++ + a++;
Console.WriteLine(b);
Console.WriteLine(a);
*/

/*int a = 3;
int b = a++ + ++a;
Console.WriteLine(b);
Console.WriteLine(a);*/

int mathScore = Convert.ToInt32(Console.ReadLine());
int engScore = Convert.ToInt32(Console.ReadLine());
bool isGetAward=mathScore>=90&& engScore>=90;
Console.WriteLine(isGetAward);