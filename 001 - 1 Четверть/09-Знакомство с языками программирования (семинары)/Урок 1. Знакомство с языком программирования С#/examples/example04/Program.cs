﻿Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        Console.Write("Понедельник");
        break;
    case 2:
        Console.Write("Вторник");
        break;
    case 3:
        Console.Write("Среда");
        break;
    case 4:
        Console.Write("Четверг");
        break;
    case 5:
        Console.Write("Пятница");
        break;
    case 6:
        Console.Write("Суббота");
        break;
    case 7:
        Console.Write("Воскресенье");
        break;
    default:
        Console.Write("Ошибка!!! Введённая цифра не является днём недели!");
        break;

}