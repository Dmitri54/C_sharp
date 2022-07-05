/* 17. Напишу программу, которая принимает на вход координаты точки (X и Y),
причём X = 0 и Y = 0 и выдаёт номер четверти плоскости, в которой находится эта точка */

Console.WriteLine("Введите координаты точки (X и Y)");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
else Console.WriteLine("Введены не корректные данные");
