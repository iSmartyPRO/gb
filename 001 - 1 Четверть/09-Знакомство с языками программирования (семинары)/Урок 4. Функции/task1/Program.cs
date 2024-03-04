// Задание 1. Совместная работа
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

int[] randomArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,10);
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

bool isSimple(int number) 
{
    if(number == 0 || number == 1)
    {
        return false;
    }
    else
    {
        for(int i = 2; i < number; i++)
        {
            if(number % i == 0) return false;
        }
        return true;
    }
}

int Count(int[] arr) 
{
    int count = 0;
    foreach (var item in arr)
    {
        if(isSimple(item)) 
        {
            Console.Write($"{item} ");
            count++;
        }4 task1
    }
    return count;
}


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = randomArr(new int[n]);

printArr(arr);
Console.WriteLine(Count(arr));