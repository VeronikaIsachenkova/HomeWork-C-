// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Square(int n)
// {
//     int curr = 1;
//     int result = 0;
//     while (curr <= n)
//     {
//         result = curr * curr * curr;

//         if (curr == n)
//         {
//             Console.Write(result);
//         }
//         else
//         {

//             Console.Write(result + ",");
//         }
//         curr++;
//     }
// }
// Console.Write("Введите цифру: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Square(num);

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void FiveNumber(string number)
// {
//     if (number[0] == number[4] || number[1] == number[3])
//     {
//         Console.WriteLine("Ваше число: {number} - палиндром.");
//     }
//     else Console.WriteLine("Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5)
// {
//     FiveNumber(number);
// }
// else Console.WriteLine("Введи правильное число");


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введи координаты первой точки: ");
// int x1 = int.Parse(Console.ReadLine());
// int y1 = int.Parse(Console.ReadLine());
// int z1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введи координаты второй точки: ");
// int x2 = int.Parse(Console.ReadLine());
// int y2 = int.Parse(Console.ReadLine());
// int z2 = int.Parse(Console.ReadLine());
// double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) +
//                    Math.Pow((y2 - y1), 2) +
//                    Math.Pow((z2 - z1), 2));

// Console.WriteLine($"Расстояние от первой точки до второй ={distance} ");