System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(System.Console.ReadLine());

if (num2 * num2 == num1)
{
    System.Console.WriteLine($"ДА. Квадрат первого числа {num1} равен {num2}");
}
else
{
    System.Console.WriteLine($"НЕТ. Квадрат первого числа {num1} не равен {num2}");
}