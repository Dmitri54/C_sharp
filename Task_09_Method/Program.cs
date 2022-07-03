﻿// 9. Напишу программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8
// --------------------------------------------------------------------------
// Реализую при помощи метода (функции).

int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");

int MaxDigit(int num) // Метод, который покажет наибольшую цифру двухзначного числа.
// передаю (int num), т.к. не нужно использовать глобальную переменную (rndNum), нужно создавать 
// локальную, чтобы не было конфликта. 
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0; // Random().Next() - может вывести одинаковые цифры (11).
    // поэтому, чтобы не было ошибки, буду в этом случае выводить 0. 
    return firstDigit > secondDigit ? firstDigit : secondDigit; // Вернет целочисленное значение.
}
int maxDigit = MaxDigit(rndNum); // Определю новую переменную, чтобы сохранить результат работы 
// метода MaxDigit с числом (rndNum).
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры одинаковые"; // Определю новую переменную с
//  типом STRING, для корректного вывода. В данной строке я буду обрабатывать те значения, которые лежат 
// в maxDigit (цифра или 0). Словами: Если maxDigit > 0, то вывожу maxDigit, иначе вывожу СООБЩЕНИЕ 
// ПОЛЬЗОВАТЕЛЮ. Чтобы int maxDigit передать в string result, нужно конвертировать maxDigit.ToString()
// Console.WriteLine($"Наибольшая цифра цисла {rndNum} => {maxDigit}"); 
Console.WriteLine($"Наибольшая цифра цисла {rndNum} => {result}");
