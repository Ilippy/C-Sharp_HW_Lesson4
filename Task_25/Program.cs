// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using NumberMain;
internal class Program
{
    private static void Main(string[] args)
    {
        int a = Numbers.EnterNumber("Введите целое число");
        int b = Numbers.EnterNumber("Введите степень целого числа");

        ShowPowNumber(a, b);
        ShowExponentiationNumber(a,b);
    }

    private static void ShowPowNumber(int a, int b)
    {
        System.Console.WriteLine($"{a}, {b} -> {Math.Pow(a, b)}");
    }

    static void ShowExponentiationNumber(int a, int b)
    {
        int result = a;
        for (int i = 1; i < b; i++)
        {
            result *= a;
            // System.Console.WriteLine($"{i} -> {result}");
        }
        System.Console.WriteLine($"{a}, {b} -> {result}");
    }
}