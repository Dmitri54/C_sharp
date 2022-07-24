/* 47. Задам двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
// -------------------------------------------------------------------------------------------------------

double[,] GreateMatrixRndInt(int row, int col, int min, int max) // Метод, создает и заполняет двумерный массив
// случайными вещественными числами.
{
    double[,] array = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * (max - min) + min;
            
        }

    }
    return array;
}

void PrintMatrix(double[,] array) // Этот метод напечатает двумерный массив в консоль.
{
    Console.WriteLine($"Сгенерированный двумерный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double roundinNum = Math.Round(array[i, j], 2); // Наконец-то получилось!!!
            //Math.Round(array[i, j], 2); - округляет значение до двух знаков после запятой.
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{roundinNum,4}, ");
            else Console.Write($"{roundinNum,4}]");
        }
        Console.WriteLine();
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

double[,] arrayResult = GreateMatrixRndInt(m, n, minDiap, maxDiap);
PrintMatrix(arrayResult);