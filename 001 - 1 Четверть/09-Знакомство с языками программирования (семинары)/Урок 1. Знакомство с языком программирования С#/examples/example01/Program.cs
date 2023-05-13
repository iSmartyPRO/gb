Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine($"Результат: {result}");

if (num > 0)
    Console.WriteLine("Было введено положительное число");
else if (num == 0)
    Console.WriteLine("Был введён ноль!");
else
    Console.WriteLine("Было введено отрицательное число");