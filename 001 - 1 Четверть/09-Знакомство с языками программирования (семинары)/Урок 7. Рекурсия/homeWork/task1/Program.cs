// Задача 1
// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreationArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] ReverseArray(int[]array)
{
Array.Reverse(array);
return array;
}

// Рекурсия
void PrintArrRecursion(int[] array, int current = 0)
        {
            
            if (current == array.Length) return;
            else
            {
                Console.Write($"{array[current++]} ");
                PrintArrRecursion(array, current);
            }
        }


Console.Write("Введи размер массива: ");
int sizeUser = Convert.ToInt32(Console.ReadLine());
int[] arrayUser = CreationArray(sizeUser);
PrintArray(arrayUser);
Console.WriteLine();
arrayUser = ReverseArray(arrayUser);
PrintArrRecursion(arrayUser);