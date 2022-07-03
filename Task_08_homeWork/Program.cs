// 8. Напишу программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// -------------------------------------------------------------------------

Console.WriteLine("Эта программа принимает на вход число (N), а на выходе показывает \nвсе чётнык числа от 1 до N.");
Console.Write("Введите число и нажмите Enter: ");
// char simvol = ','; 
int number = int.Parse(Console.ReadLine());
for (int index = 1; index <= number; index++) if (index %2 == 0) 
{
    Console.Write($"{index}, ");
    if (index == number) break;
    // Console.Write(simvol);
    // Console.Write(" ");
    
}



