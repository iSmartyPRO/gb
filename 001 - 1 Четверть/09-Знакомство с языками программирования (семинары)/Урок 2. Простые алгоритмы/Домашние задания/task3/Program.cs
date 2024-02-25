int number = new Random().Next(10,99);

Console.WriteLine($"Рандомное значения для задачи: {number}");
int num1 = number / 10;
int num2 = number % 10;

if(num1 > num2) Console.WriteLine(num1);
    else Console.WriteLine(num2);