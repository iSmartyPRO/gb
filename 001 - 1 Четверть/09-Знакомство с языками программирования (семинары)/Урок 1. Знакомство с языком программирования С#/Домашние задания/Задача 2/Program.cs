Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b) {
    Console.WriteLine("max = " + a);
} 
if (b > a) {
    Console.WriteLine("max = " + b);
}
if(b == a) {
    Console.WriteLine("Оба значения равны!!!");
}