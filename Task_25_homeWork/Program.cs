/* 25. Напишу цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
// ----------------------------------------------------------------------

Console.WriteLine("Программа возводит число А в натурадбную степень В.");
Console.Write("Введите число А и нажмите Enter: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В и нажмите Enter: ");
int numB = Convert.ToInt32(Console.ReadLine());
int result = numA;
while (numB > 1)
{
    result*=numA;
    numB--;
}
Console.WriteLine(result);


