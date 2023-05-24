int Prompt(string message) {
    System.Console.Write(message);
    int result = Convert.ToInt32(System.Console.ReadLine());
    return result;
}

int sumAll(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}

int num = Prompt("Введите число: ");

Console.WriteLine($"Сумма чисел {num} равен {sumAll(num)}");
