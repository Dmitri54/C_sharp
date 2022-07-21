/* 53. Задам двумерный массив. 
Напишу программу, которая поменяет местами 
первую и последнюю строку массива. */
// -----------------------------------------------------------------------------------------------

Console.Clear();

int[,] FillMatrixRNDInt(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    Console.WriteLine($"Сгенерирован двумерный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ",");
            else Console.Write(array[i, j] + "]");
        }
        Console.WriteLine();
    }
}

void ChangeRow(int[,] array)
// Есть         Надо
//  1 2 3 4 5   7 6 5 4 2
//  6 7 8 9 8   6 7 8 9 8
//  7 6 5 4 2   1 2 3 4 5 
{
    int idx1 = 0; // Первая строка.
    int idx2 = array.GetLength(0) - 1; // Последняя строка.
    for (int i = 0; i < array.GetLength(1); i++) // Иду по столбцам. i - это просто переменная.
    {
        int row = array[idx1, i];  // Записал значение первой переменной первой строки (1) в новую переменную.
        array[idx1, i] = array[idx2, i]; // Записал значение первой переменной последней строки (1 = 7).
        array[idx2, i] = row; // Записал в значение первой переменной первой строки (7 = 1) в значение первой переменной последней строки.
    }

}

Console.Write($"Введите число строк матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите число столбцов матрицы: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = FillMatrixRNDInt(row, col);
PrintMatrix(array);
ChangeRow(array);
PrintMatrix(array);

