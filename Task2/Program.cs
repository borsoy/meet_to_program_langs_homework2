// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Promt(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int number3 = 0;
int number = Promt("Введите число >");

if (number >= 100 && number < 1000)
{
    number3 = number % 10;
    Console.WriteLine($"{number} -> {number3}");
}
else
{
    Console.WriteLine($"Число {number} не является трёхзначным!");
}

