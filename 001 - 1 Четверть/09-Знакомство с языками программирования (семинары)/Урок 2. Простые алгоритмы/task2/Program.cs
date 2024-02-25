// Напишите программу, которая принимает 
// на вход трёхзначное число и возводит
// вторую цифру этого числа в степень
// равную третьей цифре

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num2 = number / 10 % 10;
int num3 = number % 10;

Console.WriteLine($"Результат: {Math.Pow(num2, num3)}");