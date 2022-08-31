// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int SumNumbers(int num)
// {
//     int result = 0;
//     int i = 0;
//     for (int curr = 0; curr <= num; curr++)
//     {
//         i = num - num % 10;
//         result = result + (num - i);
//         num = num / 10;
//     }
//     return result;
// }

// int sumNumbers = SumNumbers(num);
// Console.WriteLine($"Сумма цифр в числе: " + sumNumbers);

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Naturalnumber(int numberA, int numberB)
// {
//     int result = 1;
//     for (int curr = 1; curr <= numberB; curr++)
//     {
//         result = result * numberA;
//     }
//     return result;
// }

// Console.WriteLine("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int result = Naturalnumber(numberA, numberB);
// Console.WriteLine($"{numberA} в степени {numberB} = " + result);

// Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] GetArray(int[] array)                                  // Метод заполнения массива, тип данных массива int[] 
// {                                                            
//     Random rand = new Random();                             // Создание рандомной переменной
//     Console.Write("[");                                     //Обрамили []
//     for (int i = 0; i <array.Length; i++)
//     {
//         array[i] = rand.Next(10, 100);                     // Заполнение массива рандомными числами
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");                                    //Обрамили []
//     return array;
// }
// int[] arr = new int[6];
// GetArray(arr);
                          

