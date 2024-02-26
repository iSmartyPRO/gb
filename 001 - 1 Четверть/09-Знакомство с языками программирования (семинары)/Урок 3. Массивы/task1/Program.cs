// Задание 1. Совместная работа
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];

// ---------------------------------

Console.WriteLine(mas);

// ---------------------------------

Console.WriteLine("while method");
int index = 0;
while(index < mas.Length) 
{
    Console.Write($"{mas[index]} ");
    index++;
}
Console.WriteLine("\n");

Console.WriteLine("for method");
for(int i = 0; i < mas.Length; i++)
{
    Console.Write($"{mas[i]} ");
}
Console.WriteLine("\n");

// ---------------------------------

Console.WriteLine("foreach method");
foreach(var item in mas) 
{
    Console.Write($"{item} ");
}
Console.WriteLine("\n");

// ---------------------------------

Console.WriteLine("void function method");

void printMas(int[] col)
{
    foreach(var item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine("\n");
}

printMas(mas);

// ---------------------------------

Console.WriteLine("Случайные числа");

int[] Random_mas(int[] col)
{
    for(int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1,10);
    }
    return col;
}

int[] new_mas = Random_mas(mas);

printMas(new_mas);

// ---------------------------------

Console.WriteLine("Поиск в массиве\n");

Console.Write("Введите число для поиска: ");
int find = Convert.ToInt32(Console.ReadLine());

int count = 0;
for(var i = 0; i < new_mas.Length; i++)
{
    if(new_mas[i] == find) 
    {
        Console.WriteLine($"Число {find} найден в массиве с индексом {i}");
        count++;
    }
}
Console.WriteLine($"Искомое число {find}, было найдено {count} раз");