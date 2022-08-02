/* Задам значения M и N. 
Напишу программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
// -------------------------------------------------------------------------------------------------

Console.Clear();
Console.Write($"Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write($"Введите число N: ");
int n = int.Parse(Console.ReadLine());

int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма чисел M и N = {sum} ");
        return;
    }
    PrintSumm(m, n - 1, sum);
}

// Работает.
