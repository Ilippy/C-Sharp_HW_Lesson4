// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        int number = Numbers.EnterNumber("Введите целое число");
        ShowSumDigitsOfNumber(number);
    }

    static void ShowSumDigitsOfNumber(int number)
    {
        int result = 0;
        int tempNumber = number;
        while (tempNumber != 0)
        {
            result += tempNumber % 10;
            tempNumber /= 10;
        }
        Console.WriteLine($"{number} -> {result}");
    }
}