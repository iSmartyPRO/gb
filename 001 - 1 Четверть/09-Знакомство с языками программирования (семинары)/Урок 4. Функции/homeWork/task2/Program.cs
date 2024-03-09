// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

// Пример:
// [344 452 341 125] => 2

int[] randomArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}

void printArr(int[] arr)
{
    foreach(var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void showEvenArr(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            Console.WriteLine($"Чётные числа из массива: {arr[i]}");
            count++;
        }
    }
    Console.WriteLine($"Общее кол-во чётных чисел в массиве: {count}");
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = randomArr(new int[n]);

printArr(arr);

showEvenArr(arr);