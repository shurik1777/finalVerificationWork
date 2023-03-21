/*
 Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
 либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

 Примеры:

 ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
 ["1234", "1567", "-2", "computer science"] -> ["-2"]
 ["Russia", "Denmark", "Kazan"] -> []

 */
// Формирование массива вводом значений с клавиатуры.
string[] CreateAnArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
}
// Вывод массива введенного с клавиатуры и результирующегося на печать.
string[] arrayOutput = CreateAnArray();
Console.WriteLine($"[{string.Join(", ", arrayOutput)}] -> [{string.Join(", ", IteratingThroughArray(arrayOutput))}]");
// Метод перебора длины полученных символов после формирования массива.
string[] IteratingThroughArray(string[] original)
{
    string[] result = new string[original.Length];
    int count = 0;

    for (int i = 0; i < original.Length; i++)
    {
        if (original[i].Length <= 3)
        {
            result[count] = original[i];
            count++;
        }
    }
    return result;
}