// ## Задача 2: 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

Console.Write("Введите координату X: ");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int numberY = Convert.ToInt32(Console.ReadLine());

if(numberX == 0 || numberY == 0) 
{
    Console.WriteLine("Координата X или Y не может быть равна нулю");
}
else {
    if(numberX > 0 && numberY > 0) Console.WriteLine("1");
        else if(numberX < 0 && numberY > 0) Console.WriteLine("2");
            else if(numberX < 0 && numberY < 0) Console.WriteLine("3");
                else if(numberX > 0 && numberY < 0) Console.WriteLine("4");
}