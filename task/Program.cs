
string[] SetArray(int Length)
{
    string[] array = new string[Length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите строку массива :\t");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintResult(string[] array)
{
    int i = 0;
    int rand2 = new Random().Next(array.Length - 2, array.Length + 1);
    for (int a = 0; a < rand2; a++)
    {
        string[] array2 = new string[array.Length - 1 - a];
        int rand = new Random().Next(0, array.Length - 1 - a);
        for (i = rand; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        for (i = 0; i < array.Length - 1 - a; i++)
        {
            array2[i] = array[i];
        }
        if (a == rand2 - 1) System.Console.WriteLine("[" + string.Join(", ", array2) + "]");
    }
}

int N = ReadInt("Задайте длину массива: ");
System.Console.WriteLine();
string[] text = SetArray(N);
System.Console.WriteLine();
System.Console.WriteLine($"Изначальный массив: "); 
PrintArray(text);
System.Console.WriteLine();
System.Console.WriteLine($"Результат: "); 
PrintResult(text);
