// Задача 3.
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void findNumber(int m, int n)
{
    if (n > m)
    {
        if (n <= m) return;
        findNumber(m, n - 1);
        Console.Write($"{n} ");
    }
}

Console.Write("Введи число M: ");
int m = Convert.ToInt32(Console.ReadLine())-1!;
Console.Write("Введи число N: ");
int n = Convert.ToInt32(Console.ReadLine())!;
findNumber(m, n);