/* 38. Задам массив вещественных чисел. 
Найду разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */
// ---------------------------------------------------------------------------------------

int[] GreateArrayRndInt(int size, int begin, int end) // Метод - создает и заполняет массив вещественных чисел.
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
        else Console.Write($"{array[i]}] -> ");
    }
}

void PrintRes(int res) // Метод - напечатает ответ.
{
    Console.Write($"{res}");
}

int DifferMinAndMaxPos(int[] array) // Метод - находит разницу между max и min элементом массива.
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        res = array[0] - (array[array.Length - 1]);
    }
    return res;
}


Console.Write("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] genarr = GreateArrayRndInt(insize, min, max);
int result = DifferMinAndMaxPos(genarr);

PrintArray(genarr);
PrintRes(result);
