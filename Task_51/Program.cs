/* 51. Задать двумерный массив. 
Найдити сумму элементов, находящихся на главной диагонали 
с индексами (0,0); (1;1) и т.д. */
// ---------------------------------------------------------------------------------------------------
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
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, ");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int SumMainDiag(int[,] array) // Метод найдет сумму элементов, находящихся на главной диагонали с индексами (0,0); (1;1) и т.д.
{
    int sunElMainDiag = 0;
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        sunElMainDiag += array[i, i];

    }
    return sunElMainDiag;
}

Console.Write("Введите количетво строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количетво строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] genArray = GreateMatrixRndInt(m, n, min, max);
PrintMatrix(genArray);

int resultSum = SumMainDiag(genArray);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали равна {resultSum}");



