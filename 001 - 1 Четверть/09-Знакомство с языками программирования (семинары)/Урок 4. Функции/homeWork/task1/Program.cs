// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

// Пример:
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

bool checkVar2Quit(string str) {
    if(checkInt(str)){
        
        return false;
    }
    else {
        if(str.Contains('q'))
        {
            return true;
        }
        return false;
    }

}

bool checkInt(string str)
{
    if(int.TryParse(str, out int value))
    {
        return true;
    }
    return false;
}




Console.Write("Введите значение: ");
string str = Console.ReadLine();
while(!checkVar2Quit(str)) {
    Console.Write("Введите значение: ");
    str = Console.ReadLine();
}