/* 35. Задать одномерный массив из 123 случайных чисел.
Найти количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. 
В своём решении сделаю для 123.

[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

int SearchElem (int[] array, int begin, int end) // Метод - считает в массиве, количество элементов попадающих в диапазон
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= begin && array[i] <= end) count++;
    }
    return count;
}

int[] GreateArrayRndInt(int size, int begin, int end) // Метод - создает и заполняет массив элементами.
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}

void PrintArray(int[] array) // Метод - напечатает массив в консоль.
{
    Console.WriteLine($"Сгенерированный массив из {array.Length} элементов:");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.WriteLine($"{array[i]}]");
    }
}

void PrintRes(int res) // Метод - напечатает ответ.
{
    Console.Write($"Количество элементов массива, входит в диапазон [10...99] -> {res}");
}

Console.Write("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] genarr = GreateArrayRndInt(insize, min, max);
// int[] genarr = {10, 11, 12, 13, 14}; // Для проверки.
int result = SearchElem(genarr, 10, 99);

PrintArray(genarr);
PrintRes(result);

