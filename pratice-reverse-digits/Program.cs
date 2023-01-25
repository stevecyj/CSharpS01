int number = Convert.ToInt32(Console.ReadLine());
int unitDigit = number % 10;
int tensDigit = number / 10 % 10;
int hundredsDigit = number / 100;
Console.WriteLine("" + unitDigit + tensDigit + hundredsDigit);