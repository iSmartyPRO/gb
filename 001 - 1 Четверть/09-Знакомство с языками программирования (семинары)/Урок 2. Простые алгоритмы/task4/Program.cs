﻿// Задание 4*. Совместная работа
// Напишите программу, которая выводит третью 
// с конца цифру заданного числа или сообщает, 
// что третьей цифры нет.

// Пример:
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Математическое решение");
if(number < 100) {
    Console.WriteLine("Третьей цифры нету");
}
else
{
    while(number > 999){
        number /= 10;
    }
    Console.WriteLine(number % 10);   
}


Console.WriteLine("Строковое решение");
string numberStr = Convert.ToString(number);
if (numberStr.Length < 3)
{
Console.WriteLine("Третьей цифры нет!!!");
}
else Console.WriteLine(numberStr[2]);