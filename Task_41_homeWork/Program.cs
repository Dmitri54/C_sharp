/* 41. Пользователь вводит с клавиатуры M чисел. 
Посчитаю, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223 -> 3 */
// -------------------------------------------------------------------------------------------------

int CountNumMoreThanZero(int[] array) // Метод - посчитает количество чисел в массиве больше нуля.
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
        
    }
    return count;
}

void PrintArray(int[] array) // Метод - напечатает числа, которые ввел пользователь в консоль.
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write(" ");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + " ");
    }
}

void PrintAnswer(int answer) // Метод - напечатает ответ.
{
    Console.Write($"-> {answer}");
}

Console.WriteLine("Программа посчитает количество положительных чисел введенных вами.");
Console.Write("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
// Чтение номеров(чисел) с консоли, заданных в одной строке, разделенных пробелом.
PrintArray(arr);
int result = CountNumMoreThanZero(arr);
PrintAnswer(result);
