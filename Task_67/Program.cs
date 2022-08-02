/* 67. Напишу программу, которая 
будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */

Console.Clear();
Console.Write("Задайте число: ");
int num = int.Parse(Console.ReadLine());

int sum = NaturalNumberSum(num, 0);
System.Console.WriteLine(sum);

int sum2 = NaturalNumberSumVar2(num);
System.Console.WriteLine(sum2);

int NaturalNumberSum(int num, int sum)
{
    sum += num % 10;
    if (num / 10 == 0) return sum;
    else return NaturalNumberSum(num / 10, sum);
}

// Второй вариант, преподователя. Решение в одну строку.
int NaturalNumberSumVar2(int num)
{
    if (num > 0) return num % 10 + NaturalNumberSumVar2(num / 10);
    return 0;
}

