// Задание 2. Работа в сессионных залах
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2


int[] randomArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,100);
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

int numCount(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if(item % 10 == 1 && item % 7 == 0) count++;
    }
    return count;
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = randomArr(new int[n]);

printArr(arr);

Console.WriteLine($"{numCount(arr)}");