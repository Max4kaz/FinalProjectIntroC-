// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int numberM = GetNumber("Введите число M: "),
    numberN = GetNumber("Введите число N: ");
Console.WriteLine(SumIntervalOfNumbers(numberM, numberN));

int SumIntervalOfNumbers(int number1, int number2)
{
    int min = number1,
        max = number2;
    if (min > max)
    {
        min = number2;
        max = number1;
    }
    if (min == max)
        return min;
    else
    {
        return min + SumIntervalOfNumbers(min + 1, max);
    }
}

int GetNumber(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
