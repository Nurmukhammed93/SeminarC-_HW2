// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Отрицательные числа должны нормально работать.
// -645 -> 5
// 645 -> 5
// 78 -> третьей цифры нет
// 3261279 -> 6

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

if (num < 0)
{
    num = - num;
}

else if (num < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}

else if (num <= 999) 
{
    num = num % 10;
}

else if (num <= 9999)
{
    num = num / 10 % 10;
}

else if (num <= 99999)
{
    num = num / 100 % 10;
}

else if (num <= 999999)
{
    num = num / 1000 % 10;
}

else if (num <= 9999999)
{
    num = num / 10000 % 10;
}

Console.WriteLine(num);
