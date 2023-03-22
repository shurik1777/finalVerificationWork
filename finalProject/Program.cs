/*
 Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
 либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

 Примеры:

 ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
 ["1234", "1567", "-2", "computer science"] -> ["-2"]
 ["Russia", "Denmark", "Kazan"] -> []

 */
// Создания массива строк из ввода с клавиатуры.
string[] CreateAnArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
}
// Вывод на печать имеющегося массива и сформированого массива из строк, длина которого <= 3 символа.
string[] arrayOutput = CreateAnArray();
Console.WriteLine($"[{string.Join(", ", arrayOutput)}] -> [{string.Join(", ", IfStringOfArray(arrayOutput))}]");
// Метод перебора длины полученных символов после формирования массива.
string[] IfStringOfArray(string[] arrayString)
{
    string[] tempArray = new string[arrayString.Length];
    int j = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= 3)
        {
            tempArray[j] = arrayString[i];
            j++;
        }
    }
    string[] resultArray = new string[j];

    for (int i = 0; i < j; i++)
        resultArray[i] = tempArray[i];
    return resultArray;
}
