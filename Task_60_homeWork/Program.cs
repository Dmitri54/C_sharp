/* 60. Сформирую трёхмерный массив из неповторяющихся двузначных чисел. 
Напишу программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
// -------------------------------------------------------------------------------------------------


void Create3dArrayInt(int[,,] array3D) //Метод создаст трёхмерный массив из неповторяющихся двузначных чисел. 
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray3D(int[,,] array3D) // Метод распечатает 3D массив.
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                if (j == 0) Console.Write($"{array3D[i, j, k]}");
                if (j < array3D.GetLength(1) - 1) Console.Write($"({i},{j},{k}) ");
                else Console.Write($" ");
            }
            
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine($"Введите размер массива X x Y x Z:");
Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = new int[x, y, z];
Create3dArrayInt(array3D);
Console.WriteLine($"Сгенерирован трёхмерный массив из неповторяющихся двузначных чисел:");
PrintArray3D(array3D);

// Работает корректно, если вводить массив размером 2 x 2 x 2.
// А вот как в примере не могу (попробую переписать).