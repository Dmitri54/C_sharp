/* 52. Задам двумерный массив из целых чисел. 
Найду среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 
4,6; 5,6; 3,6; 3. */
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
    Console.WriteLine($"Сгенерирован двумерный массив:");
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

void AverageColumns(int[,] array)
{
    double sumCol = 0;
    double averageCol = 0.0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumCol = 0; // каждую итерацию цикла sumCol нужно обнулять, чтобы каждый столец считался заново
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumCol += array[i, j];
        }
        averageCol = Math.Round(sumCol / array.GetLength(0), 1, MidpointRounding.ToZero);
        // averageCol = sumCol / array.GetLength(0); 
        Console.Write(averageCol + "; "); // в каждой итерации цикла по столбцам печатается результат
    }
    
}

Console.Write("Введите количетво строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количетво столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число диапазона: ");
int minDiap = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int maxDiap = Convert.ToInt32(Console.ReadLine());

int[,] arrayResult = GreateMatrixRndInt(m, n, minDiap, maxDiap);
PrintMatrix(arrayResult);
AverageColumns(arrayResult);
