// ## Задача 4: 

// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

int number = new Random().Next(1,99999);

Console.WriteLine($"Рандомное значение для задачи: {number}");

string stringNumber = Convert.ToString(number);

int index = 0;
while(stringNumber.Length > index) {
    if(stringNumber.Length == index + 1) Console.Write($"{stringNumber[index]} ");
        else Console.Write($"{stringNumber[index]}, ");
    index++;
}