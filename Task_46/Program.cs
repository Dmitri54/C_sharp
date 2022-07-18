﻿// Урок 7. Семинар. 
// Как нужно писать код.
// --------------------------------------------------------------------------------------------------
// Разделение строк по сепоратору (разделитель). Подсказка к 41 задачи.
// string[] input = Console.ReadLine().Split(',').ToArray(); // Если нужно ввести с клавиатуры много чисел.
// Split(','). - позволит получить массив чисел, введенных через запятую.
// По умолчанию делит строку по пробелу.
// "2 3 4 5 6 7 8 9" - по умолчанию получу.
// "2,3,4,5,6,7,8,9" - через запятую.
// ToArray(); - пишу, т.к. нужно сделать явно приведение к массиву.
// -----------------------------------------------------------------------------------------------------
/* 46. Задам двумерный массив размером m*n, 
заполненный случайными целыми числами. 
m = 3, n = 4.
1  4  8 19
5 -2 33 -2
77 3  8  1  */
// ------------------------------------------------------------------------------------------------------

int[,] GreateMatrixRndInt(int row, int col, int min, int max) // Метод, создает и заполняет двумерный массив с элементами.
// Двумерный массиве - это разделение между запятыми. Перед запятой и после запятой есть значение.
// А если написать в [,,] - трехмерный массив.
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

int[,] arrayResult = GreateMatrixRndInt(3, 4, 10, 30);
PrintMatrix(arrayResult);


