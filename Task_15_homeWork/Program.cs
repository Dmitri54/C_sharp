/* 15: Напишу программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
// --------------------------------------------------------------------------

Console.Write("Введите цифру от 1 до 7 и нажмите Enter: ");
int day = Convert.ToInt32(Console.ReadLine());
switch(day)
{
    case 1: Console.WriteLine("Нет. Понедельник это будний день"); break;
    case 2: Console.WriteLine("Нет. Вторник это будний день"); break;
    case 3: Console.WriteLine("Нет. Среда это будний день"); break;
    case 4: Console.WriteLine("Нет. Четверг это будний день"); break;
    case 5: Console.WriteLine("Нет. Пятница это будний день"); break;
    case 6: Console.WriteLine("Да. Суббота это выходной день"); break;
    case 7: Console.WriteLine("Да. Воскресенье это выходной день"); break;
    default: Console.WriteLine("Это не цифра от 1 до 7"); break;
}

// Решить через if esle не получилось.