// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine($"Введите целое число");
int num = int.Parse(Console.ReadLine()!);
int x = num;
int count = 0;
while (num > 0)
{
    num = num / 10;
    count++;
}
if (count < 3)
{
    System.Console.WriteLine($"Третьей цифры нет");
}
if (count > 2)
{
while (x > 999)
{
    x = x / 10;
}
int result = x % 10;
System.Console.WriteLine($"Третья цифра: {result}");}