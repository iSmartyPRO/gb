// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

// Пример:
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

bool checkVar2Quit(string input) {
    if(checkInt(input)){
        
        return false;
    }
    else {
        if(input.Contains('q'))
        {
            return true;
        }
        return false;
    }

}

bool checkInt(string input)
{
    if(int.TryParse(input, out int value))
    {
        int sum = 0;
        while(value > 0)
        {
            sum += value % 10;
            value /= 10;
        }
        if(sum % 2 == 0)
        {
            return true;
        }
    }
    return false;
}


while(true) {
    Console.Write("Введите значение: ");
    string input = Console.ReadLine();
    if(checkVar2Quit(input) || checkInt(input))
    {
        Console.WriteLine("STOP");
        break;
    }
}