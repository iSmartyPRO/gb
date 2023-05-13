int Max(int num1, int num2, int num3) {
    int max = num1;
    if(num1 > max) max = num1;
    if(num2 > max) max = num2;
    if(num3 > max) max = num3;
    return max;
}

int[] arr = {12,23,36,48,54,36,76,81,19};

for(int i = 0; i < arr.Length; i++){
    System.Console.WriteLine($"arr[{i}] = {arr[i]}");
}

int max = Max(
    Max(arr[0], arr[1], arr[2]), 
    Max(arr[3], arr[4], arr[4]), 
    Max(arr[6], arr[7], arr[7])
);


System.Console.WriteLine($"Max is: {max}");