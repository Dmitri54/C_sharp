/* 17. Напишу программу, которая принимает на вход координаты точки (X и Y),
причём X = 0 и Y = 0 и выдаёт номер четверти плоскости, в которой находится эта точка */

Console.WriteLine("Введите координаты точки (X и Y)");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// Первый вариант решения.
// -----------------------------------------------------------------------------------
// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Введены не корректные данные");

// -----------------------------------------------------------------------
// Решение методом.

// string Quarter(int xc, int yc)
// {
//     string result = ""; // Что бы вернуть строку, создам переменную (пустая строка) в которую буду записывать значение.
//     if (x > 0 && y > 0) result = "Первая четверть";
//     else if (x < 0 && y > 0) result = "Вторая четверть";
//     else if (x < 0 && y < 0) result = "Третья четверть";
//     else if (x > 0 && y < 0) result = "Четвертая четверть";
//     else result = "Введены не корректные данные";
//     return result;
// }
// ---------------------------------------------------------------------------
// Переписал код без создания переменной.
string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Введены не корректные данные";
}

string result = Quarter(x, y);
string result2 = Quarter(9, 1);
Console.WriteLine(result);
Console.WriteLine(result2);