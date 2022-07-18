/* 48. Задам двумерный массив размером m на n, 
каждый элемент в массиве находится по формуле:
Amn = m + n.
Вывести полученный массив на экран.
m = 3, n = 4.
0 1 2 3 
1 2 3 4
2 3 4 5  */
// -----------------------------------------------------------------------------------------------------

int[,] GreateMatrixNotRndInt(int row, int col) //Метод, создает и заполняет двумерный массив с элементами как в примере..
{
    int[,] array = new int[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j; // Тут складываю строку и столбец.
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

            if (j == 0) Console.Write("|");
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ", ");
            else Console.Write(array[i, j] + "|");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = GreateMatrixNotRndInt(3, 4);
PrintMatrix(arrayResult);
