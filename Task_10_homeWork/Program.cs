﻿/* 10. Напишу программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
// -----------------------------------------------------------------------

Console.WriteLine("Это программа принимает на вход трёхзначное число и на выходе показывает \nвторую цифру этого числа.");
Console.Write("Введите трёхзначное число и нажминет Enter: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = (number / 10) % 10;
Console.WriteLine($"Вторая цифра => {secondDigit}");

