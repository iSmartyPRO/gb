
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next(50,200);
Console.WriteLine($"Число на входе: {number}");

if (number <= 999 && number >= 100)
{
    int num1 = number / 100;
    int num2 = number % 10;

    Console.WriteLine("--- Вариант 1 ---");
    Console.Write(num1);
    Console.WriteLine(num2);

    Console.WriteLine("--- Вариант 2 ---");
    Console.WriteLine($"{num1}{num2}");

    Console.WriteLine("--- Вариант 3 ---");
    Console.WriteLine($"{num1 * 10 + num2}");
} else {
    Console.WriteLine("Введено не трёхначное число");
}