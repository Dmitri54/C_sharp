/* Задам массив вещественных чисел. 
Найду разницу между максимальным и минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] */
// ---------------------------------------------------------------------------------------

int[] GreateArrayRndInt(int size, int begin, int end) // Метод - создает и заполняет массив НЕ вещественных чисел.
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

void PrintAnswer(int answer) // Метод - напечатает ответ.
{
    Console.Write($"{answer}");
}

int DifferMinAndMaxNum(int[] array) // Метод - находит разницу между max и min элементом массива.
{
    int min = array[0];
    int max = array[0];
    int deff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    return deff = max - (min);
}

Console.Write("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] genarr = GreateArrayRndInt(insize, min, max);
// double[] genarr = {3.5, 7.1, 22.9, 2.3, 78.5};
PrintArray(genarr);

int diffenence = DifferMinAndMaxNum(genarr);
PrintAnswer(diffenence);

