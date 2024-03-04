// Задание 3. Совместная работа

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] getArrayInput(int size)
{
    int[] arr = new int[size];
    for(int i = 1; i <= size; i++)
    {
        Console.Write($"Введите значение {i}: ");
        arr[i-1] = Convert.ToInt32(Console.ReadLine());
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

double arrayToNumber (int[] arr)
{
    double s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        double p = Math.Pow(10, arr.Length - i - 1);
        s = s + arr[i] * p;
    }
    return s;
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = getArrayInput(n);

printArr(arr);

Console.WriteLine($"Result: {arrayToNumber(arr)}");