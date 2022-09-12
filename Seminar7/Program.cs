/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
// Console.Clear();
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// double[,] array = GetArray(rows, cols, 100);

// PrintArray(array);


// double[,] GetArray(int m, int n, int max) {
//     double[,] array = new double[m, n];
//     for(int i=0; i < m; i++) {
//         for(int j=0; j < n; j++) {
//             array[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] array) {
//     for(int i=0; i < array.GetLength(0); i++) {
//         for(int j=0; j < array.GetLength(1); j++) {
//             Console.Write($" {array[i, j]}");
//         }
//         Console.WriteLine();
//     }
    
// }


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
// Console.Clear();
// Console.Write("Введите номер индекса строки массива: ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер индекса столбца массива: ");
// int col = Convert.ToInt32(Console.ReadLine());

// // создаем массив
// int[,] array = GetArray(4, 4);

// GetElementArrayToIndex(row, col, array);

// инициализация массива и заполнение случайными числами
// int[,] GetArray(int m, int n) {
//     int[,] array = new int[m, n];
//     for(int i=0; i < m; i++) {
//         for(int j=0; j < n; j++) {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }


// // вывод значений массива
// void PrintArray(int[,] array) {
//     for(int i=0; i < array.GetLength(0); i++) {
//         for(int j=0; j < array.GetLength(1); j++) {
//             Console.Write($" {array[i, j]}");
//         }
//         Console.WriteLine();
//     }
    
// }

// // поиск и вывод значения элемента массива
// void GetElementArrayToIndex(int row, int col, int[,] array) {

//     if(row > array.GetLength(0) || col > array.GetLength(1)) {
//         Console.WriteLine("Ошибка: Выход за пределы массива!");
//     } else {
//         PrintArray(array);
//         Console.WriteLine($"Элемент массива [{row},{col}] = {array[row, col]}");
//     }

// }


/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
// Console.Clear();
// int[,] array = GetArray(4, 4);

// PrintArray(array);

// GetAverageValueColumnArray(array);

// // инициализация массива и заполнение случайными числами
// int[,] GetArray(int m, int n) {
//     int[,] array = new int[m, n];
//     for(int i=0; i < m; i++) {
//         for(int j=0; j < n; j++) {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }


// // вывод значений массива
// void PrintArray(int[,] array) {
//     for(int i=0; i < array.GetLength(0); i++) {
//         for(int j=0; j < array.GetLength(1); j++) {
//             Console.Write($" {array[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }

// // вычисляем среднее значение по столбцам массива
// void GetAverageValueColumnArray(int[,] array) {
//     double avgCol = 0;
//     for(int i=0; i < array.GetLength(0); i++) {
//         Console.Write("-->");
//         for(int j=0; j < array.GetLength(1); j++) {
//             Console.Write($" {array[j, i]}");
//             avgCol += array[j, i];
//         }
//         Console.WriteLine($" Среднее значение [{i}] столбца = {avgCol/array.GetLength(1)}");
//         avgCol = 0;
//     }
// }