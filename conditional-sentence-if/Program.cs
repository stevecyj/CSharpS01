/*int age = Convert.ToInt32(Console.ReadLine());
if (age <= 16)
{
    Console.WriteLine("無法進入");
}
else
{
    Console.WriteLine("可以進入");
}
Console.WriteLine("finish");*/

/*int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 1)
{
    Console.WriteLine("奇數");
}
else
{
    Console.WriteLine("偶數");
}*/

int age = Convert.ToInt32(Console.ReadLine());
if (age >= 18 && age <= 30)
{
    Console.WriteLine("可以參加活動");
    if (age % 2 == 1)
    {
        Console.WriteLine("獲得獎品");
    }
    else
    {
        Console.WriteLine("沒有獲得獎品");
    }
}
else
{
    Console.WriteLine("不可以參加活動");
}