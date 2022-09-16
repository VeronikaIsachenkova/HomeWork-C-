
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерной массива.
// Написать метод который будет проверять каждую строку, перемещая элементы в порядке убывания и сравнивая их друг с другом.

// void PrintArray()
// {
//     int[,] arr = new int[4, 4] { { 16, 24, 11, 18 }, { 47, 24, 26, 78 }, { 25, 74, 37, 20 }, { 39, 27, 98, 12 } };

//     for (int i = 0; i < arr.GetLength(0); i++)
//         SortRow(arr, i);

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//             Console.Write(arr[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.ReadLine();
// }
// void SortRow(int[,] massiv, int r)
// {
//     for (int i = 0; i < massiv.GetLength(1); i++)
//         for (int j = i + 1; j < massiv.GetLength(1); j++)
//         {
//             if (massiv[r, i] < massiv[r, j])
//             {
//                 int tmp = massiv[r, i];
//                 massiv[r, i] = massiv[r, j];
//                 massiv[r, j] = tmp;
//             }
//         Console.WriteLine();
//         }
        
// }
// PrintArray();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// / В прямоугольной матрице найти строку с наименьшей суммой элементов.
// // Сделала метод, который по строке вычисляет значение суммы каждой строки.
// // Через ветвление вычислила наименьшую сумму.


// int[,] arr = new int[5, 4] { { 16, 79, 99, 18 }, { 47, 24, 26, 78 }, { 25, 74, 37, 20 }, { 39, 27, 98, 12 }, { 35, 46, 73, 23 } };
// int sumOneLine = 0;
// int sumTwoLine = 1;
// int sumThreeLine = 2;
// int sumForLine = 3;
// int sumFiveLine = 4;
// int sum = 0;
// void PrintArray()
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//             Console.Write(arr[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int SumArray(int r)
// {
//     sum = 0;
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         sum = sum + arr[r, j];
//     }
//     return sum;
// }


// PrintArray();
// sumOneLine = SumArray(sumOneLine);
// sumTwoLine = SumArray(sumTwoLine);
// sumThreeLine = SumArray(sumThreeLine);
// sumForLine = SumArray(sumForLine);
// sumFiveLine = SumArray(sumFiveLine);


// Console.WriteLine($"Сумма первой строки = {sumOneLine}");
// Console.WriteLine($"Сумма второй строки = {sumTwoLine}");
// Console.WriteLine($"Сумма третьей строки = {sumThreeLine}");
// Console.WriteLine($"Сумма четвертой строки = {sumForLine}");
// Console.WriteLine($"Сумма пятой строки = {sumFiveLine}\n");

// int min = sumOneLine;
// if (min > sumTwoLine)
//     min = sumTwoLine;
// if (min > sumThreeLine)
//     min = sumThreeLine;
// if (min > sumForLine)
//     min = sumForLine;
// if (min > sumFiveLine)
//     min = sumFiveLine;
// Console.WriteLine($"Наименьшая сумма элементов строки в матрице = {min}");

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// / Спирально заполнить двумерный массив

// void Main()
// {
//     int[,] array = new int[7, 7];
//     SnakeFill(array.GetLength(0), array.GetLength(1), array);
// }

// void PrintArray(int[,] array)
// {
//     for (int y = 0; y < array.GetLength(0); y++)
//     {
//         for (int x = 0; x < array.GetLength(1); x++)
//             Console.Write($"{array[y, x]} ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SnakeFill(int endRow, int endCol, int[,] array)
// {
//     int value = 1;
//     int startRow = 0;
//     int startCol = 0;

//     while (startRow < endRow && startCol < endCol)
//     {
//         for (int i = startCol; i < endCol; ++i)
//             array[startRow, i] = value++;

//         startRow++;

//         for (int i = startRow; i < endRow; ++i)
//             array[i, endCol - 1] = value++;

//         endCol--;

//         if (startRow < endRow)
//         {
//             for (int i = endCol - 1; i >= startCol; --i)
//                 array[endRow - 1, i] = value++;
//         }

//         endRow--;

//         if (startCol < endCol)
//         {
//             for (int i = endRow - 1; i >= startRow; --i)
//                 array[i, startCol] = value++;
//         }

//         startCol++;
//     }
//     PrintArray(array);
// }
// Main();