/* 32: Напишу программу замены элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */
// -------------------------------------------------

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

int[] SwapElep (int[] array) // Метод - умножит каждый элемент массива на -1, чтобы поменять знак.
{
    int[] resArr = new int[array.Length]; //Создам новый массив, чтобы перезаписать массив новыми значениями.
    for (int i = 0; i < array.Length; i++)
    {
        resArr[i] = array[i] * -1;
    }
    return resArr;
}

Console.Write("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] genarr = GreateArrayRndInt(insize, min, max);
int[] swapElep = SwapElep(genarr);

PrintArray(genarr);
PrintArray(swapElep);