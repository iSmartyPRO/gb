int Prompt(string message) {
    System.Console.Write(message);
    int result = Convert.ToInt32(System.Console.ReadLine());
    return result;
}

bool Check(int num) {
    return (num < 100 || num >=1000) ? false : true;
}

int num = Prompt("Введите трёхзначное число: ");

if(Check(num)){
    int num2 = (num % 100 - num % 10) / 10;
    System.Console.WriteLine("Вторая цифра числа " + num + " является " + num2);
} else {
    System.Console.WriteLine("Ошибка! На вход принимается только трёхзначные числа");
}