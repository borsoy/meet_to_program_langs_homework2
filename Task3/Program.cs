// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

int Promt(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Promt("Введите число >");

if (number > 5 && number < 8)
{
    Console.WriteLine($"{number} -> Да");
}
else
{
    Console.WriteLine($"{number} -> Нет");
}