/* 22. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

Console.WriteLine("Введите число для вычисления набора квадратов: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = 0;
int count = 1;
while (count <= num)
{
    square = count*count;
    Console.WriteLine($"{count} -> {square} ");
    count++;
}

