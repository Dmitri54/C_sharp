// 4. Напишу программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22
// ---------------------------------------------------------------------------------------------

Console.WriteLine("Это программа принимает три числа и выдаёт максимальное из этих чисел.");
Console.Write("Введите первое число и нажмите Enter: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число и нажмите Enter: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число и нажмите Enter: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
