/* 34. Задам массив заполненный случайными положительными трёхзначными числами. 
Напишу программу, которая покажет количество чётных чисел в массиве.
Пример ответа:
[345, 897, 568, 234] -> 2 */


int[] GreateArrayRndInt(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}

void PrintArray(int[] array) 
{
    Console.WriteLine($"Сгенерированный массив из {array.Length} элементов:");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}] -> ");
    }
}

int CountPosNum (int[] array) // Метод - считает в массиве, количество положительных элементов.
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) count++;
    }
    return count;
}

void PrintRes(int res) // Метод - напечатает ответ.
{
    Console.Write($"{res}");
}

Console.WriteLine("Эта программа покажет количество чётных чисел в массиве.");
Console.Write("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное положительное трёхзначное число диапазона от 100: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное положительное трёхзначное число диапазона до 1000: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] genarr = GreateArrayRndInt(insize, min, max);
int countPosNum = CountPosNum(genarr);

PrintArray(genarr);
PrintRes(countPosNum);

