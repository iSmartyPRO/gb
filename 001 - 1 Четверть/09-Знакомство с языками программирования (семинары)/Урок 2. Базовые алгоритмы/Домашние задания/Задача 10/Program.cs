Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99 && num < 1000) {
    int num2 = (num % 100 - num % 10) / 10;
    Console.WriteLine("Вторая цифра числа " + num + " является " + num2);

} else {
    Console.WriteLine("Ошибка! На вход принимается только трёхзначные числа");
}