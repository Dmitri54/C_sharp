/* 31. 
1. Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. 
2. Найдите сумму отрицательных и положительных элементов массива.
3. Вывод данных.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20. */
// ---------------------------------------------------------------------
// Разбил задачу на подзадачи 1, 2 и 3. Буду решать методами. 

int[] GreateArrayRndInt(int size, int begin, int end) // Первый метод, создает и заполняет массив элементами.
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}

int[] GetSumNegPosElem(int[] array) // Метод считает сумму положительных и отрицательных элемемнтов. 
{
    int sumNeg = 0;
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i];
        }
        else
        {
            sumPos += array[i];
        }
    }
    return new[] { sumNeg, sumPos }; // Позиция элемемнта sumNeg - 0, а sumPos - 1.
}

void PrintArray(int[] array) // Этот метод напечатает массив в консоль как в примере.
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

void PrintSumNegPosElem(int[] sum)
{
    Console.WriteLine(); 
    Console.WriteLine($"Сумма положительных чисел = {sum[1]}");
    Console.WriteLine($"Сумма отрицательных чисел = {sum[0]}");
}

// int[] resArray = GreateArrayRndInt(12);
int[] resArray = GreateArrayRndInt(12, -9, 9); // Так программа более гибкая т.к. можно при вызове метода
//  сразу задать количество элементов в массиве и диапазон значений в которых нужно заполнить его. 
PrintArray(resArray); // Печатаю массив.

int[] sumNegPosElem = GetSumNegPosElem(resArray); // Посчитает и запомнит два числа.
PrintSumNegPosElem(sumNegPosElem); // Напечатает ответ.

// Console.WriteLine(); // Напишу отдельный метод, для вывода ответа. Эта строка не нужна. 
// Следующие две в метод.
// Console.WriteLine($"Сумма положительных чисел = {sumNegPosElem[1]}");
// Console.WriteLine($"Сумма отрицательных чисел = {sumNegPosElem[0]}");

