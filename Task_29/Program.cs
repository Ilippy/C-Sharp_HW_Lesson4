// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array1 = CreateRandomArray();
        PrintArray(array1);
        int[] array2 = CreateArray();
        PrintArray(array2);
    }

    static int[] CreateRandomArray()
    {
        int arrayLength = Numbers.EnterNumber("Введите длину рандомного массива");
        int[] array = new int[arrayLength];
        Random random = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = random.Next(100);
        }
        return array;
    }

    static int[] CreateArray()
    {
        int arrayLength = Numbers.EnterNumber("Введите длину массива");
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = Numbers.EnterNumber($"Введите {i+1} эллемент массива");
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
    }
}