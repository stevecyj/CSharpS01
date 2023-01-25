/*int number = Convert.ToInt32(Console.ReadLine());
int unitDigit = number % 10;
int tensDigit = number / 10 % 10;
int hundredsDigit = number / 100;
Console.WriteLine("" + unitDigit + tensDigit + hundredsDigit);*/

int num = Convert.ToInt32(Console.ReadLine());
int tensDigit = num / 10 % 10;
int thousandsDigit = num / 1000 % 10;
int numNew = thousandsDigit * 10 + tensDigit;
char c=(char)numNew;
Console.WriteLine(c);