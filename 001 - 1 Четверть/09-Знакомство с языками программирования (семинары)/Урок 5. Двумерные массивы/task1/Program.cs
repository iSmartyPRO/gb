// Задание 1. Совместная работа
// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

void printArr2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Squartes(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                arr[i,j] = arr[i,j] * arr[i,j];
            }
        }
    }
    return arr;
}

Console.Write("Введите размерность массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность массива m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[n,m];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = new Random().Next(1, 10);
    }
}

Console.WriteLine("Исходный массив:");
printArr2(arr);

Console.WriteLine();
Console.WriteLine("Изменённый массив: ");
printArr2(Squartes(arr));
