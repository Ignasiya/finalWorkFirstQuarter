using System;
using static System.Console;

Clear();
string[] primaryText = InputText($"Введите текст и нажмите Enter: ");
string[] result = ResultText(primaryText, $"Введите необходимую длину символов: ");
WriteLine($"[{String.Join(" ", result)}]");

string[] InputText(string text)
{
    Write(text);
    string[] arrayText = ReadLine().Split(" ");
    return arrayText;
}

string[] ResultText(string[] array, string text)
{
    Write(text);
    int size = int.Parse(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < size) count++;
    }
    string[] arrayText = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length < size)
        {
            arrayText[j] = array[i];
            j++;
        }
    }
    return arrayText;
}