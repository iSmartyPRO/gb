// Задание 2
// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

int[] arr = new int[10];

Console.WriteLine("Заполняем массив данными");
for(var i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-10, 10);
}

Console.WriteLine("Отображаем массив с заполненными данными");
foreach(int item in arr)
{
    Console.Write($"{item} ");
}
Console.WriteLine("\n");

Console.WriteLine("Инвертируем заполненные числа в массиве");
for(var i = 0; i < arr.Length; i++)
{
    if(arr[i] > 0) arr[i] = -arr[i];
        else arr[i] *= -1;
}

Console.WriteLine("Отображаем массив с заполненными данными");
foreach(int item in arr)
{
    Console.Write($"{item} ");
}
Console.WriteLine("\n");