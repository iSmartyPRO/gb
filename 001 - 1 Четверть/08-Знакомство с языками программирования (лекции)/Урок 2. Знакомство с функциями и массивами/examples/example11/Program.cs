void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine($"arr[{position}] = {col[position]}");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count) {
        if(collection[index] == find) {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] arr = new int[10];
int find = 6;

// print nulled array
PrintArray(arr);

// fill array
FillArray(arr);

// print filled array
PrintArray(arr);

Console.WriteLine($"Position is: {IndexOf(arr, find)}");