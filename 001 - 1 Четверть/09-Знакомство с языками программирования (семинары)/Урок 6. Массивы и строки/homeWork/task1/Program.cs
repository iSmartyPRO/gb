// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string createStringFromArr(char[,] arr)
{
    string result = "";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result += arr[i, j];
        }
    }
    return result;
}


char[,] chArr = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
Console.WriteLine(createStringFromArr(chArr));
