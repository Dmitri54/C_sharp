/* 28. Напишу программу, которая принимает на вход число N
 и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

Console.WriteLine("Программа выдает произведение чисел от 1 до N.");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Count (int number)
{
    int x = 1;
    for (int i = 1; i <= number; i++)
    {
        x = i * x;
    }    
    return x; 
    
}

int result = Count(num);
Console.Write(result);

