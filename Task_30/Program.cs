/* 30. Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */
// ---------------------------------------------------------------------------------------------
// Решение через for.

// Console.WriteLine("Программа выводит массив из 8 элементов и в случайном порядке \nзаполняет его нулями и единицами.");
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2); // Каждый следующий, заполняется рандомным числом.
//     Console.Write(array[i]);
// }

// Реализация через while. 
// Этот код позволит в VS получать разные числа.

// int[] array = new int[8];
// int len = array.Length;
// int index = 0;
// var rnd = new Random(); // Один раз создам в не цикла.
// var можно написать Random - это не явно типизированная переменная, компилятор автоматически определяет 
// тип данных, соответствующий выражению в правой части.

// while (index < array.Length)
// {
//     array[index] = rnd.Next(0, 2); // Внутри цикла вызываю .Next(0, 2) - так лучше, правильнее работает!
//     index++;
// }
// for (int i = 0; i < len; i++)
// {
//     if (i == 0) Console.Write("[");
//     if (i < len - 1) Console.Write(array[i] + ",");
//     else Console.Write(array[i] + "]");
// }

// Решение через МЕТОДОМ (лучше с ним).
// ----------------------------------------------------------------------------------------------

int[] ArrayBin(int size)
{
    int[] array = new int[size];
    int index = 0;
    var rnd = new Random();
    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 2);
        index++;
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int[] resArray = ArrayBin(12); // Тут задаю нужное количество элементов.
PrintArray(resArray);