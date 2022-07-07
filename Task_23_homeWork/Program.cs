/* 23. Напишу программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Программа запрашивает число N и выводит таблицу кубов чисел.");
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

int cube = 0;
int count = 1;

while (count <= num )
{
    cube = count * count * count;
    Console.WriteLine($"{count, 3} -> {cube, 3} ");
    count++;
}

