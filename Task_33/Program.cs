/* 33. Задать массив. Напишу программу, которая определяет, 
присутствует ли заданное число в массиве. 
4: массив [6, 7, 19, 345, 3] -> нет
3: массив [6, 7, 19, 345, 3] -> да*/

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

void PrintArray(int[] array) // Этот метод напечатает массив в консоль как в примере.
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

bool SearchElem (int[] array, int elem) // Метод - ищет в массиве заданный элемент.
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elem) return true;
    }
    return false;
}

void PrintRes (bool resSearch)
{
    string res = resSearch ? " -> ДА. Искомый элемент присутствует в массиве" : " -> НЕТ. Искомый элемент отсутствует в массиве";
    Console.WriteLine(res);
}

Console.WriteLine("Эта программа проверяет присутствует ли заданный вами элемент в массиве.");
// Console.Write("Введите размер массива: ");
// int insize = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число диапазона: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число диапазона: ");
// int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение для поиска: ");
int elem = Convert.ToInt32(Console.ReadLine());

// int[] genarr = GreateArrayRndInt(insize, min, max);
int[] arr = {6, 7, 19, 345, 3}; // Для проверки, создам массив.
PrintArray(arr); // Для проверки.
bool resultSearch = SearchElem(arr, elem); // Для проверки.
// PrintArray(genarr);
// bool resultSearch = SearchElem(genarr, elem);
PrintRes(resultSearch);
