// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Для вычисления функции Аккермана введите два неотрицательных числа.");
int numberM = GetNumber("Число m: "),
    numberN = GetNumber("Число n: ");
Console.WriteLine($"Функция Аккермана для неотрицательных целых чисел {numberM} и {numberN} равна {FunctionAckerman(numberM, numberN)}");

int FunctionAckerman(int number1, int number2)
{
    if (number1 == 0)
        return number2 + 1;
    else if (number1 > 0 && number2 == 0)
        return FunctionAckerman(number1 - 1, 1);
    else
        return FunctionAckerman(number1 - 1, FunctionAckerman(number1, number2 - 1));
}

int GetNumber(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
