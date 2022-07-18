/* 49. Задам двумерный массив. 
Найду элементы, у которых оба индекса чётные,
и заменю эти элементы на их квадраты. */
// -----------------------------------------------------------------------------------------------

int[,] GreateMatrixRndInt(int row, int col, int min, int max) // Метод, создает и заполняет двумерный массив с Rnd элементами.
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }

    }
    return array;
}

void PrintMatrix(int[,] array) // Этот метод напечатает двумерный массив в консоль.
{
    Console.WriteLine($"Сгенерированный матрица:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3}, ");
            else Console.Write($"{array[i, j], 3}]");
        }
        Console.WriteLine();
    }
}

int[,] SqrParity(int[,] array) // Метод - найдет элементы, у которых оба индекса чётные, и заменит эти элементы на их квадраты.
{
    for (int i = 0; i < array.GetLength(0); i +=2)
    {
        for (int j = 0; j < array.GetLength(1); j +=2)
        {

            array[i, j] *= array[i, j];
        }
        Console.WriteLine();
    }
    return array;
}

Console.Write("Введите количетво строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количетво строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] arrayResult = GreateMatrixRndInt(m, n, min, max);
PrintMatrix(arrayResult);

int[,] resultArray = SqrParity(arrayResult);
PrintMatrix(resultArray);

