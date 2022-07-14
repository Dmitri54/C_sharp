/* 44. Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */
// ---------------------------------------------------------------------------------------
Console.Write("Введите число Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());

int first = 0;
int second = 1;
int fibo = 0;

Console.Write($"{first} ");
Console.Write($"{second} ");

for (int i = 2; i < N; i++)
{
    fibo = first + second;
    Console.Write($"{fibo} ");
    first = second;
    second = fibo;
}



