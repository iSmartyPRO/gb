// Задание 4*. Совместная работа
// [если позволит тайминг]
// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

int number = new Random().Next(100,1000);

Console.WriteLine($"Случайно выбранная трёхзначное число: {number}");

int[] arr = new int[3];

void printArr(int[] a)
{
    foreach(var i in a)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = number % 10;
    number /= 10;
}

printArr(arr);

