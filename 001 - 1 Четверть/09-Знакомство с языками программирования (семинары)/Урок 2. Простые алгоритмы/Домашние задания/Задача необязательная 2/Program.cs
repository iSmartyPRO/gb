int Prompt(string message) {
    System.Console.Write(message);
    int result = Convert.ToInt32(System.Console.ReadLine());
    return result;
}
bool Check(int num) {
    if(num < 1 || num > 1000) {
        System.Console.WriteLine("Ошибка!!! Введённые данные должны быть в диапазоне 1-1000");
        return false;
    }
    return  true;
}
string lastSymbols(int qnty) {
    if ((qnty % 100 >= 11 && qnty % 100 <= 19) || (qnty % 10 == 0 || qnty % 10 >= 5 && qnty % 10 <= 9)){
        return "ов";
    } else if(qnty % 10 == 2 || qnty % 10 == 3 || qnty % 10 == 4) {
        return "a";
    } else {
        return "";
    }
}

int qnty = Prompt("Введите кол-во программистов в помещении: ");

if(Check(qnty)){
    System.Console.WriteLine($"В помещении {qnty} программист{lastSymbols(qnty)}");
}