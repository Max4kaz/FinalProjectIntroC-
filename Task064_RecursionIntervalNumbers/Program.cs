// Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int numberN = GetNumber("Введите число N: "),
    countNumbers = 2;
IntervalNumbers(numberN, countNumbers);
Console.Write(1);

void IntervalNumbers(int number, int count)
{
    if (count > number) 
        return;
    else
    {
        IntervalNumbers(number, count + 1);
        Console.Write(count + ", ");
    }
}

int GetNumber(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
