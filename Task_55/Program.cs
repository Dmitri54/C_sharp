/* 55. Задам двумерный массив. 
Напишу программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна
вывести сообщение для пользователя. */
// ---------------------------------------------------------------------------------------------------
Console.Clear();

int[,] GreateMatrixRndInt(int row, int col, int min, int max)
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

int[,] ChangeRowAndCol(int[,] array)
// Есть       Надо
//  1 2 3     1 6 7
//  6 7 8     2 7 6
//  7 6 5     3 8 5 
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int[,] swapArray = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            swapArray[i, j] = array[j, i];
        }
    }
    return swapArray;

}

Console.WriteLine($"Программа меняет строки на столбцы.");
Console.Write($"Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
if (col == row)
{

    Console.WriteLine($"Задайте нужный диапазон чисел.");
    Console.Write("Нижняя граница диапазона: ");
    int begin = Convert.ToInt32(Console.ReadLine());
    Console.Write("Верхняя граница диапазона: ");
    int end = Convert.ToInt32(Console.ReadLine());

    int[,] array = GreateMatrixRndInt(row, col, begin, end);
    PrintMatrix(array);
    int[,] arrayResult = ChangeRowAndCol(array);
    PrintMatrix(arrayResult);
}
else 
{
    Console.WriteLine($"Не возможно изменить строки на столбцы, замените размер матрицы.");
}