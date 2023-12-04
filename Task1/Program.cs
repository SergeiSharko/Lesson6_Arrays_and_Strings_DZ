// Задача 1: Задайте двумерный массив символов (тип char[,]).
// Создать строку из символов этого массива.
// Пример
// a b c => “abcdef”
// d e f 

char[,] charArray = {{'H','e','l','l','o',},
                     {'w','o','r','l','d',}};
string strFromCharArray = string.Empty;

foreach (var c in charArray)
    strFromCharArray += c;

Console.WriteLine($"Двумерный массив символов");
PrintCharArray(charArray," , ");
Console.WriteLine($"Строка из массива -> {strFromCharArray}");

void PrintCharArray(char[,] sourceTDArray, string separator)
{
    for (int i = 0; i < sourceTDArray.GetLength(0); i++)
    {
        for (int j = 0; j < sourceTDArray.GetLength(1); j++)
        {
            Console.Write(sourceTDArray[i, j]);
            if (j == sourceTDArray.GetLength(1) - 1) break;
            Console.Write(separator);
        }
        Console.WriteLine();
    }
}