// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 7 -> да 1 -> нет

int num;

Console.Clear();
do
{
    Console.WriteLine("Введите номер дня недели (от 1 до 7):");
    num = Convert.ToInt32(Console.ReadLine());
} while ((num < 1) | (num > 7));

if (IsTheDayHoliday(num))
{
    Console.WriteLine($"Да, день недели {num} - выходной");
}
else
{
    Console.WriteLine($"Нет, день недели {num} - не выходной");
}

// Methods

bool IsTheDayHoliday(int day)
{
    return day > 5 ? true : false;
}