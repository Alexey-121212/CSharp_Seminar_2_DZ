// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 78 -> третьей цифры нет 32679 -> 6

int num;

Console.Clear();

Console.WriteLine("Введите целое число:");
num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (num > 99)
{
    while (num > 999)
    {
        num = num / 10;
    }
    Console.WriteLine($"Третья цифра числа -> {num % 10}");
}
else
{
    Console.WriteLine("У числа нет третьей цифры");
}

