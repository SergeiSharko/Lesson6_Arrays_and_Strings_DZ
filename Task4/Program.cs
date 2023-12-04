// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
// Пример
// “Hello my world” => “world my Hello”
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.Write($"Введите строку, в которой слова будут расположены в обратном порядке -> ");
string? input = Console.ReadLine();
string[]? arrayWords = input?.Split(' ');
Array.Reverse(arrayWords!);
Console.WriteLine();
Console.Write($"{input} => [{string.Join(" ", arrayWords!)}]");