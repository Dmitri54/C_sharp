/* 44. Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */
// ---------------------------------------------------------------------------------------
Console.Write("Укажите количество чисел Фибоначчи для вывода: ");
int N = Convert.ToInt32(Console.ReadLine());

// f(n) = f(n-2) + f(n-1)
int first = 0;
int second = 1;
int counter = 0;

if (N = 1) Console.Write("0");
if (N = 2) Console.Write("1");
else
{
    int temp1 = 0;
    int temp2 = 1;
    int result = 0;
    while (counter < N)
    {
        result = temp1 = temp2;
        Console.Write();
    }
}

