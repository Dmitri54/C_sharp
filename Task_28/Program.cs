﻿/* 28. Напишу программу, которая принимает на вход число N
 и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */
// -----------------------------------------------------------------------------
// Console.WriteLine("Программа выдает произведение чисел от 1 до N.");
// Console.Write("Введите число: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// Первый вариант --------------------------------------------------------------

// int Count (int num)
// {
//     int x = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         x = i * x;
//     }    
//     return x; 

// }

// int result = Count(numberN);
// Console.Write(result);

// ----------------------------------------------------------------------------
// Второй вариант.

// int Mult(int num)
// {
//     int mult = 1; // Создам переменную равную т.к., от 1 до N.
//     for (int i = 1; i <= num; i++) // i - будет счетчиком, = 1, т.к. на ноль умножать нельзя.
//     {
//         mult *= i;
//     }
//     return mult;
// }
// int result = Mult(numberN);
// Console.WriteLine($"Произведение чисел от 1 до {numberN} = {result}");

// Третье решение с ПЕРЕПОЛНИЕМ типа данных.
// Если ввести большое число программа выдаст не верный ответ, будет переполнение типа данных переменной.
// Можно задать doube - но жто не решит. Что бы избежать этой ОШИБКА переполниения типа, напишу:

Console.Write("Введите число: ");
int numberN = int.Parse(Console.ReadLine());
int res = 1;
int start = 1;

while (start <= numberN)
{
    checked // Выдаст ошибку и закончит работу.
    {
        res *= start;
        start++;
    }

}
Console.WriteLine(res);
