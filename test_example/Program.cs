
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] FillStartArray(int lenArray)
{
    string [] startArray = new string[lenArray];
    for (int i = 0; i<startArray.Length;i++)
        startArray[i] = Console.ReadLine();
    return startArray;
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
    j = 0;
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



