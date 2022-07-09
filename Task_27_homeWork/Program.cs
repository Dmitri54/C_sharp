/* 27. Напишу программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Программа выдаёт сумму цифр в числе.");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int remainder = 0;
    while (num != 0)
    {
        remainder += num % 10;
        num = num / 10;
    }
    return remainder;
}
int result = SumNumbers(number);
Console.WriteLine($"Сумма цифр числа {number} -> {result}");

