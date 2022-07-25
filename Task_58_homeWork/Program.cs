/* 58. Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
// -------------------------------------------------------------------------------------------------------
// Чтобы перемножить матрицы между собой, нужно, 
// чтобы количество столбцов матрицы A совпадало с количество строк матрицы B!!!
// --------------------------------------------------------------------------------------------------------

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

void MulMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix) // Метод перемножит и вернет результирующую матрицу.
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}


Console.Write("Введите количеcтво строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количеcтво столбцов первой (и строк второй матрицы): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количеcтво столбцов второй матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите диапазона: от 1 до ");
int range = Convert.ToInt32(Console.ReadLine());

int[,] arrayMatrix1 = GreateMatrixRndInt(m, n, range);
Console.WriteLine($"Сгенерирована первая матрица:");
PrintMatrix(arrayMatrix1);

int[,] arrayMatrix2 = GreateMatrixRndInt(n, p, range);
Console.WriteLine($"Сгенерирована вторая матрица:");
PrintMatrix(arrayMatrix2);

int[,] MulArrayMatrix = new int[m,p];  
MulMatrix(arrayMatrix1, arrayMatrix2, MulArrayMatrix);
Console.WriteLine($"Произведение матриц:");
PrintMatrix(MulArrayMatrix);

// Работает!