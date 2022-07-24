/* 50. Напишу программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет */
// -----------------------------------------------------------------------------------------------------

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

// void FindElPos(int[,] array, int posRow, int posCol)
// {
//     if (posRow < array.GetLength(0) && posCol < array.GetLength(1))
//     {
//         Console.WriteLine($"На позиции строка № {posRow}, столбец № {posCol} " +
//                           $"находится элемент со значением: {array[posRow - 1, posCol - 1]}");
//     }
//     else Console.WriteLine($"Cтрока № {posRow}, столбец № {posCol} - такой позиции в массиве нет.");
// }

void SearchElem(int[,] array, int posRow, int posCol) // Метод ищет элемент по индексу.
{
    int number = array[0, 0];
    int ind1 = 0, ind2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (ind1 <= array.GetLength(0) - 1 && ind2 <= array.GetLength(1) - 1
            && ind1 >= 0 && ind2 >= 0)
            {
                ind1 = posRow;
                ind2 = posCol;
                number = array[ind1, ind2];
            }
            else Console.WriteLine($"Cтрока № {ind1}, столбец № {ind2} - такой позиции в массиве нет.");
        }
    }
    Console.WriteLine($"Элемент массива = {number} с адресом [{ind1},{ind2}]");
}

Console.Clear();
Console.Write("Введите количетво строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количетво столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число диапазона: ");
int minDiap = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int maxDiap = Convert.ToInt32(Console.ReadLine());

int[,] arrayMatrix = GreateMatrixRndInt(row, col, minDiap, maxDiap);
PrintMatrix(arrayMatrix);

Console.WriteLine("Эта программа проверяет присутствует ли заданный вами элемент в массиве.");
Console.Write("Введите номер строки элемента для поиска: ");
int rowSerch = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента для поиска: ");
int colSerch = Convert.ToInt32(Console.ReadLine());

// FindElPos(arrayResult, rowSerch, colSerch);
SearchElem(arrayMatrix, rowSerch, colSerch);
