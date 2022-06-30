// 1. Написать программу, которая принимает на вход два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> да

Console.WriteLine("Эта программа проверяет, является ли первое число квадратом второго.");
Console.Write("Введите первое число и нажмите Enter: ");
int First = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число и нажмите Enter: ");
int Second = Convert.ToInt32(Console.ReadLine());

if (Second * Second == First) 
{
    Console.WriteLine($"Да, первое число - это квадрат второго: {Second} * {Second} = {First}");
}
else
{
    Console.WriteLine($"Нет, первое число не является квадрат второго {Second} * {Second} != {First}");
}



