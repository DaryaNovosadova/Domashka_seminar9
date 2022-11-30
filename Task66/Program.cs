//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
if (M >= N)
{
    Console.WriteLine("Число М должно быть меньше числа N");
    return;
}
int sum = 0;
void SumNumbers(int M, int N)
{
    if (M < N)
    {
        sum = sum + (M++);
        SumNumbers(M, N);
    }
    else
    {
        Console.Write($"{sum + N}");
    }
}
SumNumbers(M, N);


