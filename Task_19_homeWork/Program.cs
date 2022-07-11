/* 19. Напишу программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */ 

Console.WriteLine("Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.Write("Введите пятизначное число и нажмите Enter: ");
int numBer = Convert.ToInt32(Console.ReadLine());

// string Comparison (int fiveNum)

int temp = numBer;
int rev = 0;
while(numBer > 0)
{
    int digital = numBer % 10;
    rev = rev * 10 + digital;
    numBer = numBer / 10;
}
if(temp == rev)
{
    Console.WriteLine($"{temp} -> Да");
}
else
{
    Console.WriteLine($"{temp} -> Нет");
}
