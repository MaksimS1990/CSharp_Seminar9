// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.");

void Recurtion(int n)
{
    if (n < 1)
    {
        return;
    }
    if (n > 1)
    {
        Recurtion(n - 1);
    }
    if (n == 1)
        Console.Write($"{n}");
    else

        Console.Write($", {n}");
}




Recurtion(15);
Console.WriteLine();
