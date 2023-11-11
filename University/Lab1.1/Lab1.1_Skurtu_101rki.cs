using System;
class SwapVertical {
     static void Main() {
        /// Объявление переменных /// 
        int rows = 4;
        int columns = 5;

        /// Создание двумерного массив ///
        int[,] array = new int[rows, columns];

        /// Введите значения массива ///
        Console.WriteLine("Введите значения массива:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++) {
                Console.Write($"array[{i},{j}] = ");
                array[i, j] = int.Parse(s: Console.ReadLine());
            }

        /// Исходный массив ///
        Console.WriteLine("\nИсходный массив:");
        PrintArray(array);

        /// Замена столбцов ///
        for (int j = 0; j < columns / 2; j++)
            for (int i = 0; i < rows; i++) {
                int temp = array[i, j];
                array[i, j] = array[i, columns - 1 - j];
                array[i, columns - 1 - j] = temp;
            }

        /// Измененный массив ///
        Console.WriteLine("\nИзмененный массив:");
        PrintArray(array);
    }

    static void PrintArray(int[,] array) {
        /// Объявление переменных по полученному массиву ///
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        /// Вывод массива ///
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++)
                Console.Write($"{array[i, j]}\t");
            Console.WriteLine(); /// Переход строки ///
        }
    }
} 
