/* 36. Задам одномерный массив, заполненный случайными числами. 
Найду сумму элементов, стоящих на нечётных позициях.
Пример:
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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

void PrintRes(int res) // Метод - напечатает ответ.
{
    Console.Write($"{res}");
}

int SumNumOddPosition (int[] array) // Метод - найдет сумму элементов стоящих на нечётных позициях в массиве.
{
    int result = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0) result += array[i];
    }
    return result;
}

Console.WriteLine("Эта программа найдет сумму элементов, стоящих на нечётных позициях.");
Console.Write("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] genarr = GreateArrayRndInt(insize, min, max);
// int[] genarr = {3, 7, 23, 12};
int sumNumOddPos = SumNumOddPosition(genarr);

PrintArray(genarr);
PrintRes(sumNumOddPos);

