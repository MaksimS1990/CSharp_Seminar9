// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Программа на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.");

Console.WriteLine();
Console.WriteLine("Введите возводимое число");
int R;
while (!int.TryParse(Console.ReadLine()!, out R) || R <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неверный ввод");
    Console.ResetColor();
    Console.WriteLine("Введите возводимое число");
}

Console.WriteLine();
Console.WriteLine("Введите степень");
int Z;
while (!int.TryParse(Console.ReadLine()!, out Z) || Z <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неверный ввод");
    Console.ResetColor();
    Console.WriteLine("Введите степень");
}

int Degree(int a, int b)
{
    if (b == 0) return 1;
    return a * Degree(a, b - 1);
    
    //else return 1 / (a * Degree(a, -b - 1));
}
Console.WriteLine();
Console.WriteLine($"{R}^{Z} = " + Degree(R, Z));
Console.WriteLine();
