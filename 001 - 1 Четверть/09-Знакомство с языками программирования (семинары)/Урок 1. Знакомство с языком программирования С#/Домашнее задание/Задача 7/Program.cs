Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if(x > 10) {
    while(x > 99) x /= 10;
    Console.WriteLine(x % 10);
} else {
    Console.WriteLine("Нет");
}