// Задача 3: 
// Задайте произвольную строку. Выясните, является ли она палиндромом.

bool IsPalindrome(string str)
{
    string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return normalized.SequenceEqual(normalized.Reverse());
}

string input = "Шалаш";
bool isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome ? "Да" : "Нет");