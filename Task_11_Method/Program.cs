// 11. Напишу программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// -----------------------------------------------------------------------
// Решение при помощи метода.

var rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число: {rndNum}");
int CutMid (int num)
{
    int firsDigit = num / 100 * 10;
    int thridDigit = num % 10;
    return firsDigit + thridDigit;
}
int result = CutMid(rndNum);
Console.WriteLine($"Полученное двухзначное число (через метод): {result}");


