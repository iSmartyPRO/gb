// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное само на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат: " + num * num);

if(num>0) 
    Console.WriteLine("Было введено положительное число");
else if(num ==0) 
    Console.WriteLine("Был введён ноль");
else 
    Console.WriteLine("Было введено отрицательное число");