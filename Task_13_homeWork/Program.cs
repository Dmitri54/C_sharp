/* 13. Напишу программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
// ----------------------------------------------------------

Console.WriteLine("Эта программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write("Введите число и нажмите Enter: ");
int numBer = Convert.ToInt32(Console.ReadLine());
int n = numBer.Length;

int Method(int numBer, int n)
{
    index = 0;
    if (int n[index] > 3) Console.WriteLine($"Третья цифра числа {numBer} => {n[index]}");
    return;

}


// Console.WriteLine($"Третья цифра числа {numBer} => {n[index]}");
// if(index < n)
// {
//     int thridNum = numBer / 100;

//     Console.WriteLine(index); // - покажет на экране соответствующее значение индекса.
//     break; // - это оператор, который прервет выполнение после первого совпадения array[index] == find.

// }


