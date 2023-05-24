int Prompt(string message) {
    System.Console.Write(message);
    int result = Convert.ToInt32(System.Console.ReadLine());
    return result;
}

int[] generateArr(int length, int min, int max)
{
    int[] arr = new int[length];
    Random random = new Random();
    for(int i = 0; i < length; i++){
        //Console.WriteLine(random.Next(min, max));
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void printArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.WriteLine("]");
}
int length = Prompt("Введите длину массива: ");
int min = Prompt("Введите min: ");
int max = Prompt("Введите max: ");
int[] arr = generateArr(length, min, max);
printArr(arr);