/* 42. Напишу программу, которая будет 
преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */
// ----------------------------------------------------------------------------------------

int[] ConvertToBool(int a)
{
    int b = a % 512;
    int[] boolean = new int[9];
    int razr = 256;

    for (int i = 0; i < boolean.Length; i++)
    {
        if (b >= razr)
        {
            b = b - razr;
            boolean[i] = 1;
        }
        else
        {
            boolean[i] = 0;
        }
        razr /= 2;
    }
    return boolean;
}

string MakeViewStringMassive(int[] massive)
{
    string viewString = "[";
    int j = 1;
    for (int i = 0; i < massive.Length; i++, j++)
    {
        viewString += Convert.ToString(massive[i]);
        if(j != massive.Length) viewString += ", ";
    }
    viewString += "]";
    return viewString;
}


Console.WriteLine("Программа приобразует десятичное число в двоичное.");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] result = ConvertToBool(number);

string answer = MakeViewStringMassive(result);
Console.WriteLine(answer);
