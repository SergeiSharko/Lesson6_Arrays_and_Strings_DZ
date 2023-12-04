// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// Пример
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.Write($"Введите строку на проверку является ли она палиндромом -> ");

string? input = Console.ReadLine();

if (StringIsPalindrome(input!) == true)
    Console.Write(input + " => Да");
else
    Console.Write(input + " => Нет");

bool StringIsPalindrome(string inputString)
{
    int startPos = 0;
    int endPos = inputString.Length - 1;

    while (startPos < endPos)
    {
        char firstChar = inputString[startPos],
             endChar = inputString[endPos];

        if (Char.IsSeparator(firstChar) == true || Char.IsPunctuation(firstChar) == true)
        {
            startPos++;
            continue;
        }

        if (Char.IsSeparator(endChar) == true || Char.IsPunctuation(endChar) == true)
        {
            endPos--;
            continue;
        }

        if (Char.ToLower(firstChar) != Char.ToLower(endChar)) return false;

        startPos++;
        endPos--;
    }
    return true;
}
