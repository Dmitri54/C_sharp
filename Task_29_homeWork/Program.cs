/* 29. Напишу программу, которая задаёт массив 
из 8 элементов, заполненный псевдослучайными числами
и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */

Console.WriteLine("Массив из 8 элементов, заполненный псевдослучайными числами.");

int[] ArrayBin(int size)
{
    int[] array = new int[size];
    int index = 0;
    var rnd = new Random();
    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 100);
        index++;
    }
    return array;
}

void PrintArray2(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}

void PrintArray1(int[] array) 
{
    int count = array.Length;
    for (int i = 0; i < count; i++) 
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"-> ");
}

int[] resArray = ArrayBin(8); 
PrintArray1(resArray);
PrintArray2(resArray);
