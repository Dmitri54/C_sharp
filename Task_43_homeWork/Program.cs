/* 43. Напишу программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
// ------------------------------------------------------------------------------------------------------

Console.WriteLine("Программа ищет точку пересечения двух прямых.");
Console.Write("Введите значение точки b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение точки k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение точки b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение точки k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 1); 
y = Math.Round(y, 1);
// Math.Round() - Встроенный метод округления к ближайшему числу или к ближайшему числу с заданным количеством знаков после запятой.
// В данном случае после запятой будет один знак.

Console.WriteLine($"Пересечение двух прямых в точке -> ({x};{y})");

