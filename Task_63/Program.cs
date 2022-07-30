/* 63. Задам значение N. 
Напишу программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

Console.Clear();
Console.Write("Задайте число: ");
int num = int.Parse(Console.ReadLine()); // К примеру = 6.

// void NaturalNumber(int num)
// {
//     if (num == 0) return; // Условие выхода из метода, при использовании Рекурсии, прописывается сразу (обязательно).
//     NaturalNumber(num - 1); // Вызываю рекурсию, с последнего элемента.
//     Console.Write($"{num} "); // Печатать будет с первого элемента, т.к. это стэк. Первым пришел последним ушел.
    
// }
// NaturalNumber(num); // 1 2 3 4 5 6

// Хвостовая Рекурсия, это когда Рекурсия становиться аналогом обычного цикла.

void NaturalNumber(int num)
{
    if (num == 0) return; 
    Console.Write($"{num} ");
    NaturalNumber(num - 1); 
        
}
NaturalNumber(num); // 6 5 4 3 2 1

