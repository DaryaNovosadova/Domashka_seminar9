//Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
if(number < 1) return;
Console.WriteLine();
int n = 1;
void PrintNumber(int n, int number)
{
    if(n == number)
    {
        Console.Write("{0, 3}", number);
        return;
    }
    else
    {
        Console.Write("{0, 3}", n);
    }
    PrintNumber(n +1, number);
}

for(int i = n; i <= number; i++)
{
    if(i % 2 == 0)
    {
        Console.Write("{0, 3}", i);
    }
} 


