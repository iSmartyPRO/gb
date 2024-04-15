using System.Threading.Tasks.Dataflow;

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

string[] arrayData = new string[arraySize];

for(int i = 0; i < arrayData.Length; i++){
    Console.Write($"Введите элемент массива {i + 1} из {arrayData.Length}: ");
    arrayData[i] = Console.ReadLine();
}

// Определяем размер массива по условию <= 3
int conditionArraySize = 0;
for (int i = 0; i < arrayData.Length; i++)
{
    if (arrayData[i].Length <= 3)
    {
        conditionArraySize += 1;
    }
}
// Назначаем данные массиву
string[] arrayResult = new string[conditionArraySize];
int j = 0;
for (int i = 0; i < arrayData.Length; i++)
{
    if(arrayData[i].Length <= 3)
    {
        arrayResult[j] = arrayData[i];
        j++;
    }
}

// Вывод на экран
Console.WriteLine("\nРезультат:");
if(arrayResult.Length == 0) Console.Write("[]");
for (int i = 0; i < arrayResult.Length; i++)
{
    if(i == 0) Console.Write("[");
    Console.Write($"\"{arrayResult[i]}\"");
    if(arrayResult.Length != i + 1) Console.Write(", ");
    if(arrayResult.Length == i + 1) Console.Write("]");
}   
Console.WriteLine();