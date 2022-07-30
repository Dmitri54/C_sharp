/*  65. Задать значения M и N. 
Напишу программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"  */

Console.Clear();
Console.Write($"Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write($"Введите число N: ");
int n = int.Parse(Console.ReadLine());

void NaturalNumber(int m, int n)
{
    if (m > n) // В этом случае я описал все возможные условия, поэтому не пишу return.
    {
        Console.Write($"{m} ");
        NaturalNumber(m - 1, n);
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        NaturalNumber(m + 1, n);
    }
    else 
    {
        Console.Write($"{m} ");
    }


}
NaturalNumber(m, n); // 1 2 3 4