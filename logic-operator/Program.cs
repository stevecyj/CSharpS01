/*bool a = (3<4)&&(9<6);
bool b = (3<4)&&(9<10);
bool c = !(4 < 7);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);*/

int age = Convert.ToInt32(Console.ReadLine());
bool isYouth = age >= 18 && age <= 60;
Console.WriteLine(isYouth);