//Вариант №27
//Упорядочить двумерный массив по убыванию. В полученном массиве заменить все элементы с 
//чётными индексами значениями 1 / x, где x – значение элемента.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] arr = new int[rows, columns];
        Random rnd = new Random();

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr[i, j] = rnd.Next(1, 101); // заполнение массива случайными числами от 1 до 100
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        // сортировка массива по возрастанию
        int[] tempArr = new int[rows * columns];
        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                tempArr[k] = arr[i, j];
                k++;
            }
        }
        Array.Sort(tempArr, (i, j) => j.CompareTo(i));
        k = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr[i, j] = tempArr[k];
                k++;
            }
        }

        Console.WriteLine("Отсортированный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        // замена элементов с чётными индексами элементами с нечётными индексами
        float[,] shiftedArr = new float[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                 if (j%2==0) // если индекс четный, то меняем элементы
                {
                    shiftedArr[i, j] = 1f/arr[i, j];
                }
                else // иначе оставляем элемент без изменения
                {
                    shiftedArr[i, j] = arr[i, j];
                }
            }
        }

        Console.WriteLine("Массив со заменой:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(Math.Round(shiftedArr[i, j], 2)+ " ");
            }
            Console.WriteLine();
        }
    }
}
