/* 45. Напишу программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. */
// -------------------------------------------------------------------------------------
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
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] CopyArray(int[] array) // Метод - создаст копию массива с помощью поэлементного копирования.
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < copy.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

int[] massive = GreateArrayRndInt(5, 1, 10);
PrintArray(massive);
int[] massiveCopy = CopyArray(massive);
Console.WriteLine();
PrintArray(massiveCopy);