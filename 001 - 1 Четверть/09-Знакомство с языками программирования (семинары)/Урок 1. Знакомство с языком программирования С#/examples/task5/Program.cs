Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int start = num - num - num;

while(start <= num ) {
    Console.Write($"{start}, ");
    start++;
}