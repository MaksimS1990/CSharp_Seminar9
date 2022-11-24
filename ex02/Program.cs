// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Программа задает значения M и N. Программа выводит все натуральные числа в промежутке от M до N.");

void Recurtion(int m, int n)
{
    if (n < m)
    {
        return;
    }
    if (n > m)
    {
        Recurtion(m, n - 1);
    }
    if (n == m)
        Console.Write($"{n}");
    else

        Console.Write($", {n}");
}




Recurtion(1005, 1010);
Console.WriteLine();
