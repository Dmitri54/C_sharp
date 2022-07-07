/*  26. Напишу программу, которая принимает на вход число
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

Console.WriteLine("Введите число для подсчета количества чисел в нем: ");
int num = Convert.ToInt32(Console.ReadLine());

int DigitsCount(int a) // Создам метод, который будет считать количество цифр в числе.
{
    int digitsCounters = 0; // Определю переменную, для хранения счетчика.
    while (a != 0) // Пока число не равно нулю.
    {
        a /= 10;
        digitsCounters++;
    }
    return digitsCounters;
}

int amountOfDigits = DigitsCount(num);
Console.Write($"Количество цифр в числе {num} = {amountOfDigits}.");
