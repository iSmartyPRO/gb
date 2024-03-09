// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

// Пример:
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

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

int[] askArrSize() {
    Console.Write("Введите размерность массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = randomArr(new int[n]);
    return arr;
}

int[] reverseArr(int[] arr)
{
    int rNum;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        rNum = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = rNum;
    }
    return arr;
}

int[] arrSize = askArrSize();

int[] arr = randomArr(arrSize);

Console.WriteLine("Исходный массив: ");
printArr(arr);

Console.WriteLine("Перевёрнутый массив: ");
printArr(reverseArr(arr));