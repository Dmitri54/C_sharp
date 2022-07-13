/* 39. Напишу программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

// ---------------------------------------------------------------------------------------------------

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

void Reverse (int[] array) // Метод - перевернет имеющийся массив: [1 2 3 4 5] -> [5 4 3 2 1].
{
    int size = array.Length;
    int index1 = 0; // Это первый левый элемент массива.
    int index2 = size -1; // Это первый правый элемент.
    
    while (index1 < index2)
    {
        int odj = array[index1]; // Создам временную переменную, чтобы я мог запомнить значение первого элемента.
        array[index1] = array[index2]; // В первый элемент записываю значение первого правого элемента.
        array[index2] = odj; // В крайне правый элемент записываю значение первого левого элемента.

        index1++;
        index2--;
    }
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

int[] array = GreateArrayRndInt(5, 1, 9);
PrintArray(array);
// Reverse(array); // Метод - перевернет массив.
Array.Reverse(array); // - это ВСТРОЕННЫЙ метод в C# переворота массива. 
// Можно просто вызвать её Array.Reverse(); В () нужный массив.
Console.Write(" -> "); // Вот так нужно делать!!!
PrintArray(array);


