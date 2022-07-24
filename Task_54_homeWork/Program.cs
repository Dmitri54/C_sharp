/* 54. Задам двумерный массив. 
Напишу программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
// -----------------------------------------------------------------------------------------------------
int[,] GreateMatrixRndInt(int row, int col, int diap) // Метод, создает и заполняет двумерный массив с Rnd элементами.
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(diap + 1);
        }

    }
    return array;
}

void PrintMatrix(int[,] array) // Этот метод напечатает двумерный массив в консоль.
{
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

void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.Write("Введите количетво строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количетво столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите диапазона: от 1 до ");
int range = Convert.ToInt32(Console.ReadLine());

int[,] arrayMatrix = GreateMatrixRndInt(m, n, range);
Console.WriteLine($"Сгенерирован двумерный массив:");
PrintMatrix(arrayMatrix);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(arrayMatrix);
PrintMatrix(arrayMatrix);

// Работает!