// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] arr = new int[20];                                  // Задали массив из 20 чисел.
// int index = 0;                                           
// int even = 0;                                            // even= счетчик для посчета четных элементов.
// int odd = 0;                                             // odd= счетчик для посчета не четных элементов.
// void FillArray()                                         // метод заполнения массива рандомными числами.
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
//         Console.Write($"{arr[i]} ");
//     }

// }
// FillArray();                                              // Вызов массива
// while (index < arr.Length)                                // цикл 
// {
//     if (arr[index] % 2 == 0)
//     {
//         even++;
//     }
//     else
//     {
//         odd++;

//     }
//     index++;
// }
// Console.WriteLine();
// Console.Write($"Нечетные {odd} ");
// Console.Write($"Четные {even} ");

//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19                                       
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите диапозон от min до max ");
// int minSize = int.Parse(Console.ReadLine());
// int maxSize = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите размаер массива ");
// int arrsize = int.Parse(Console.ReadLine());
// int[] arr = new int[arrsize];
// int sum = 0;
// int count = 1;
// void FillArray()
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(minSize, maxSize);
//         Console.Write($"{arr[i]} ");

//     }

// }
// void PrintSum()
// {
//     while (count < arr.Length)
//     {
//         sum += arr[count];
//         count = count + 2;
//     }
//     Console.Write($"\nCумма чисел на не четных позициях = {sum}");
// }

// Console.WriteLine("Сгенерированный массив: ");
// FillArray();
// PrintSum();

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int n = 10;                                       // переменная для размерности 
// double[] array = new double[n];                   // тип чисел(веществен.)
// double max = array[0], min = 0;                   // поиск макс и мин
// Random rand = new Random();                       // ранд. переменная
// for (int i = 0; i < n; i++)                       
// {
//     array[i] = rand.NextDouble()*1000;
//     if (max >= array[i])
//         min = array[i];
//     else
//         max = array[i];
//     Console.Write($"{array[i]} ");
// }
// for (int j = 0; j < n; j++)
// {
//     if (min > array[j])
//         min = array[j];

// }
// double difference = max - min;
// Console.WriteLine($"\nМаксимальное число = {max} ");
// Console.WriteLine($"Минимальное число = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным числом = {difference}");