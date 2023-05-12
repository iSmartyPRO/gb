int[] arr = { 21, 42, 35, 42, 54, 16, 37, 58, 12 };

int n = arr.Length;
int find = 16;
int index = 0;

/* for(int i = 0; i < n; i++) {
    if(arr[i] == find) {
        System.Console.WriteLine($"Found. Index is: {i}");
        return;
    }
} */

while (index < n)
{
    if (arr[index] == find) {
        System.Console.WriteLine($"Found. Index is: {index}");
        break;
    }
        index++;
}