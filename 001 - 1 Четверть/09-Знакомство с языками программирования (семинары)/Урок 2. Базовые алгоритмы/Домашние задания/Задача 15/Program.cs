int Prompt(string message) {
    System.Console.Write(message);
    int result = Convert.ToInt32(System.Console.ReadLine());
    return result;
}

bool isWeekNumber(int num){
    if (num > 0 && num <=7) {
        return true;
    }
    System.Console.WriteLine("Это не день недели");
    return false;
}

bool isWeekEnd(int weekDay) {
    return (weekDay == 6 || weekDay == 7) ? true : false;
}

int weekDay = Prompt("Введите день недели: ");
if(isWeekNumber(weekDay)) {
    System.Console.WriteLine("Проверка выходного дня:");
    if(isWeekEnd(weekDay)) {
        System.Console.WriteLine("Да, сегодня выходной!!!");
    } else {
        System.Console.WriteLine("Нет, сегодня работаем!");
    }
}