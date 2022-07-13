/* 40. Напишу программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */
// -----------------------------------------------------------------------------------------------------

Console.Write("Введите первую сторону треугольника A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую сторону треугольника B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую сторону треугольника C: ");
int c = Convert.ToInt32(Console.ReadLine());

bool able = CheakAbilityTriacl(a, b, c); // able - признак возможности существования треугольника.
string answer = ShowAnswer(able);
Console.WriteLine(answer);

bool CheakAbilityTriacl(int a, int b, int c) // Метод - сравнит стороны треугольника.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
{
    bool able;
    int maxSize;
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        return true;
    }
    else
    {
        return false;
    }
}

string ShowAnswer(bool ability) // Метод - выведет ответ в консоль.
{
    if (ability)
    {
        return "Треугольник возможен";
    }
    else
    {
        return "Треугольник НЕ возможен";
    }
}
