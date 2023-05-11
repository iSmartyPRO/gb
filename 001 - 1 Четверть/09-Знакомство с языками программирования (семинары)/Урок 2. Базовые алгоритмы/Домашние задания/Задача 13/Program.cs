Console.Write("Введите число более трёх знаков: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99) {
    while(num > 1000) num /= 10;
    Console.WriteLine(num % 10);
} else {
    Console.WriteLine("третьей цифры нет");
}