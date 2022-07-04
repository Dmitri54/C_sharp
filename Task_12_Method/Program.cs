/* 12. Напишу программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

Console.Write("Введите первое число и нажмите Enter: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число и нажмите Enter: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int remainder = num1 % num2;

bool Method(int num1, int num2)
{
    if (num1 % num2 == 0) return true;
    return false;
}
bool met = Method(num1, num2);
string result = Method == true ? "кратно" : "не кратно, остаток {remainder}";
Console.WriteLineConsole.Write(result);
// Решение не дописано.