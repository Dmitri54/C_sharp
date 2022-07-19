/* 38. Задам массив вещественных чисел. 
Найду разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */
// ---------------------------------------------------------------------------------------
double[] GreateArrayRndInt(int size, int begin, int end) // Метод - создает и заполняет массив вещественных чисел.
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(rnd.Next(begin, end + 1) / 10.0); 
        //rnd.NextDouble() * (begin - end) + end;
    }
    return array;
}

void PrintArray(double[] array) // Метод - напечатает массив в консоль.
{
    Console.WriteLine($"Сгенерированный массив из {array.Length} элементов:");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}] -> ");
    }
}

void PrintAnswer(double answer) // Метод - напечатает ответ.
{
    Console.Write($"{answer}");
}

double DifferMinAndMaxNum(double[] array) // Метод - находит разницу между max и min элементом массива.
{
    double min = array[0];
    double max = array[0];
    double deff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    return deff = max - (min);
}

Console.Write("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона: ");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

double[] genarr = GreateArrayRndInt(insize, minNum, maxNum);
// double[] genarr = {3.5, 7.1, 22.9, 2.3, 78.5};
PrintArray(genarr);

double diffenence = DifferMinAndMaxNum(genarr);
PrintAnswer(diffenence);


// double valueFloatRnd = new Random().NextDouble() * (max - min) + min;
