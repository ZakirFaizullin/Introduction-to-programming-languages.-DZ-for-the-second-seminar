// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine($"Введите цифру, обозначающую день недели");
int day = int.Parse(Console.ReadLine()!);
if (day < 6 && day > 0)
{
    System.Console.WriteLine($"Этот день не выходной");
}
if (day > 5 && day < 8)
{
    System.Console.WriteLine($"Это выходной день");
}
if (day < 1 || day > 7)
{
    System.Console.WriteLine($"Вы ввели некорректное число");
}
