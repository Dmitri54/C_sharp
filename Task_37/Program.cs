/* 37. Найти произведение пар чисел в одномерном массиве.
Парой считаю первый и последний элемент, второй и предпоследний
и т.д. Результат запишу в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */
// ----------------------------------------------------------------------------

int[] GreateArrayRndInt(int size, int begin, int end) // Метод - создает и заполняет массив элементами.
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}

void PrintArray(int[] array) // Метод - напечатает массив в консоль.
{
    Console.WriteLine($"Сгенерированный массив из {array.Length} элементов:");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.WriteLine($"{array[i]}]");
    }
}

int[] MutArrEl (int[] array) // Метод - перемножает первый и последний элемент, второй и предпоследний и т.д.
{
    int ten = 0;
    if (array.Length % 2 == 0) ten = array.Length / 2;
    else ten = array.Length / 2 + 1;
    int[] ResArr = new int[ten];
    for (int i = 0; i < ten; i++)
    {
        ResArr[i] = array[i] * array[array.Length - 1 - i]; //-1 чтобы не было выхода за дипазон массива, т.к. счет идет отчет от 0. 
    }
    if (ten % 2 == 0) ResArr[ten - 1] = array[ten - 1]; //  Нужно определить, если массив был изначально
    // нечетным, что бы последний элемент корректно записывался, определяю длинну результирующего массива. 
    // И если выполняется условие, то конечный элемент записываю в элемент из середины массива.
    return ResArr;
}

Console.Write("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] genarr = GreateArrayRndInt(insize, min, max);
int[] resArr = MutArrEl(genarr);

PrintArray(genarr);
PrintArray(resArr);
