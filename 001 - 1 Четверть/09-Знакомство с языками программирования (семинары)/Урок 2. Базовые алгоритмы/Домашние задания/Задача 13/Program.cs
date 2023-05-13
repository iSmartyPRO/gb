int Prompt(string message) {
    System.Console.Write(message);
    int result = Convert.ToInt32(System.Console.ReadLine());
    return result;
}
bool Check(int num) {
    return (num < 100) ? false : true;
}
int GetThirdNum(int num) {
    while(num > 1000) num /= 10;
    return num % 10;
}
int num = Prompt("Введите трёхзначное число: ");
if(Check(num)) {
    System.Console.WriteLine($"Третья цифра числа {num} является {GetThirdNum(num)}");
} else {
    System.Console.WriteLine("третьей цифры нет");
}