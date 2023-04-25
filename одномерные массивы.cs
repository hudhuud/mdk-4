//Вариант №27
//В одномерном массиве найти разность позиций наименьшего и наибольшего элементов. Обратить 
//внимание, что счёт позиций начинается с единицы.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размерность массива: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        // заполнение массива случайными числами от 1 до 100
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(1, 101);
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(arr);

        // поиск наименьшего и наибольшего элементов
        int minIndex = 0;
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (arr[i] < arr[minIndex])
            {
                minIndex = i;
            }
            if (arr[i] > arr[maxIndex])
            {
                maxIndex = i;
            }
        }

        // вычисление разности позиций наименьшего и наибольшего элементов
        int diff = Math.Abs(minIndex - maxIndex);

        Console.WriteLine($"Наименьший элемент: {arr[minIndex]}, его позиция: {minIndex+1}");
        Console.WriteLine($"Наибольший элемент: {arr[maxIndex]}, его позиция: {maxIndex+1}");
        Console.WriteLine($"Разность позиций: {diff}");
    }

    // метод для вывода элементов массива в консоль
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
