


using System.IO;
using System.Text.RegularExpressions;

Console.WriteLine("Введите текст:");
string text = Console.ReadLine();
string[] words = text.Split(new[] { '!', '?', ' ' });

Regex name = new Regex(@"www\.[a-z]*\.[a-z]*\.ru");

//Ищет во входной строке все вхождения регулярного выражения и возвращает все соответсвия

MatchCollection mat = name.Matches(text);

Console.WriteLine("\nДоменные имена:");

foreach (Match m in name.Matches(text))
{
    Console.WriteLine(m.Value);
}

