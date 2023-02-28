// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Promt(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Promt("Введите 3-хзначное число >");

int number2 = number / 10 % 10;

Console.WriteLine($"{number} -> {number2}");