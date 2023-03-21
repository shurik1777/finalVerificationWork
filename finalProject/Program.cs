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
string[] ReferToArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
}
// Вывод массива на печать.
string[] arrayOutput = ReferToArray();
Console.WriteLine($"[{string.Join(", ", arrayOutput)}] -> [{string.Join(", ", SearchingForValues(arrayOutput, 3))}]");
// Метод с счетчиком строк.
int NumberOfValues(string[] entry, int k)
{
    int count = 0;
    for (int i = 0; i < entry.Length; i++)
    {
        if (entry[i].Length <= k)
        {
            count++;
        }
    }
    return count;
}
// Метод прохода значений в массиве.
string[] SearchingForValues(string[] entry, int k)
{
    string[] exit = new string[NumberOfValues(entry, k)];
    for (int i = 0, j = 0; i < entry.Length; i++)
    {
        if (entry[i].Length <= k)
        {
            exit[j] = entry[i];
            j++;
        }
    }
    return exit;
}