// 3. Написать программу, которая будет выдавать 
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// -----------------------------------------------------------------------------------------------
Console.WriteLine("Программа выдает название дня недели по заданному номеру.\nВведите цифру от 1 до 7 и нажмите Enter: ");
// Чтобы перенести текст на следующую строку пишу "\n".
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1) Console.WriteLine("Понедельник");
else (day == 2) Console.WriteLine("Вторник");
else (day == 3) Console.WriteLine("Среда");
else (day == 4) Console.WriteLine("Четверг");
else (day == 5) Console.WriteLine("Пятница");
else (day == 6) Console.WriteLine("Суббота");
else (day == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine("Это не цифра от 1 до 7");

// -----------------------------------------------------------------------------------------------
// switch(day)
// switch() - это оператор выбора обеспечивает многонаправленное ветвление в программе. 
// Он позволяет сделать выбор среди нескольких альтернативных вариантов дальнейшего выполнения программы. 
// {
//     case 1: Console.WriteLine("Понедельник"); break;
//     case 2: Console.WriteLine("Вторник"); break;
//     case 3: Console.WriteLine("Среда"); break;
//     case 4: Console.WriteLine("Четверг"); break;
//     case 5: Console.WriteLine("Пятница"); break;
//     case 6: Console.WriteLine("Суббота"); break;
//     case 7: Console.WriteLine("Воскресенье"); break;
//     default: Console.WriteLine("Это не цифра от 1 до 7"); break;
// }
