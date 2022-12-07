/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Программа, которая из имеющегося массива строк формирует массив из строк, длина которых либо меньше либо равна 3 символа");
Console.WriteLine();
Console.WriteLine("Введите колличество элементов ");
int Volume = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[Volume];
for (int i = 0; i < Volume; i++)
{
    Console.WriteLine($"Введите {i + 1}-е слово, цифру или символ: ");
    string symbol = Console.ReadLine()!;
    Array[i] = symbol;
}
string[] NewArray = new string[Volume];
int length = 3;
int count = 0;

for (int i = 0; i < Volume; i++)
{
    if (Array[i].Length <= length)
    {
        NewArray[count] = Array[i];
        count++;
    }
}
Console.WriteLine();
PrintArray(NewArray);
