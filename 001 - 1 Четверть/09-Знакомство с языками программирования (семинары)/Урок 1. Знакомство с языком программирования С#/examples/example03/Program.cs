﻿Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num <= 7)
{
    if (num == 1) Console.WriteLine("Понедельник");
    if (num == 2) Console.WriteLine("Вторник");
    if (num == 3) Console.WriteLine("Среда");
    if (num == 4) Console.WriteLine("Четверг");
    if (num == 5) Console.WriteLine("Пятница");
    if (num == 6) Console.WriteLine("Суббота");
    if (num == 7) Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Ошибка!!! Введённая цифра не является днём недели!");
}