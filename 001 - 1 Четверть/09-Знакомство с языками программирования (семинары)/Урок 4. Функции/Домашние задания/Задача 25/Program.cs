int Prompt(string message) {
    System.Console.Write(message);
    int result = Convert.ToInt32(System.Console.ReadLine());
    return result;
}

int funcStepen(int baseNum, int stepenNum)
{
    int num = 1;
    for (int i = 0; i < stepenNum; i++)
    {
        num *= baseNum;
    }
    return num;
}

int baseNum = Prompt("Введите основание: ");
int stepenNum = Prompt("Введите степень: ");

Console.WriteLine(funcStepen(baseNum, stepenNum));