int number = new Random().Next(50,200);

string numberString = Convert.ToString(number);
Console.WriteLine($"Строковое число на входе: {numberString}");

if (numberString.Length == 3)
{
    int num1 = Convert.ToInt32(Convert.ToString(numberString[0]));
    int num2 = Convert.ToInt32(Convert.ToString(numberString[2]));

    Console.WriteLine("--- Вариант 1 ---");
    Console.Write(num1);
    Console.WriteLine(num2);

    Console.WriteLine("--- Вариант 2 ---");
    Console.WriteLine($"{num1}{num2}");

    Console.WriteLine("--- Вариант 3 ---");
    Console.WriteLine($"{num1} {num2}");
} else {
    Console.WriteLine("Введено не трёхначное строковое число");
}