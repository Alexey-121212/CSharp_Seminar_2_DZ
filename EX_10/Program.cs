// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int num;

Console.Clear();
do
{
    Console.WriteLine("Введите трехзначное число (от 100 до 999 ):");
    num = Convert.ToInt32(Console.ReadLine());
} while ((num < 100) | (num > 999));

Console.WriteLine();
Console.WriteLine($"Вторая цифра числа {num} -> " + GetSecondDigit(num));

// Methods

int GetSecondDigit(int number)
{
    return (number % 100 - number % 10) / 10;
}