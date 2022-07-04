// 12. Напишу программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно 

Console.Write("Введите первое число и нажмите Enter: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число и нажмите Enter: ");
int secondtNum = Convert.ToInt32(Console.ReadLine());

if (firstNum % secondtNum == 0) 
Console.Write($"Первое число {firstNum} кратно {secondtNum} ");
else Console.Write($"Первое число {firstNum} НЕ кратно {secondtNum}.\nОстаток от деления {firstNum % secondtNum}");