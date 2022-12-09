// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели");
int day = int.Parse(Console.ReadLine()!);

if ((day >= 6) && (day <= 7))
{
    Console.WriteLine("Выходной!");
}

else if ((day < 6) && (day > 0))
{
Console.WriteLine("Будни!");
}
else
{
    Console.WriteLine("Такого дня недели не существует!");
}