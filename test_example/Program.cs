
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void FillStartArray(string [] startArray)
{
    for (int i = 0; i<startArray.Length;i++)
    {
        Console.Write($"Введите {i+1}-ый элемент массива: ");
        startArray[i] = Console.ReadLine()!;
    }
}

void PrintArray(string [] array)
{
    if (array.Length==0)
        Console.WriteLine("[]");
    else
    {
        Console.Write("[");
        for (int i = 0; i<array.Length-1;i++)
            Console.Write($"{array[i]}, ");
        Console.Write($"{array[array.Length-1]}]");
    }
}

int LengthResultArray (string [] startArray)
{
    int lenResultArray = 0;
    for (int i = 0; i<startArray.Length;i++)
        if (startArray[i].Length<4)
            lenResultArray++;
    return lenResultArray;
}

string [] ResultArray (string [] startArray)
{
    string [] resultArray = new string [LengthResultArray(startArray)];
    int j = 0;
    for (int i = 0; i<startArray.Length;i++)
    {
        if (startArray[i].Length<4)
        {
            resultArray[j] = startArray[i];
            j++;
        }
    }
    return resultArray;
}




Console.Clear();
Console.Write("Введите размерность первоначального массива (целое число): ");
try
{
    int lenArray = Convert.ToInt32(Console.ReadLine());
    string [] array = new string [lenArray];
    FillStartArray(array);
    PrintArray(array);
    Console.WriteLine();
    PrintArray(ResultArray(array));
}
catch
{
    Console.WriteLine("Введите целое число!");
}
