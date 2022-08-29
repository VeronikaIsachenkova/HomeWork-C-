// // Seminar2 Homework
//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 


// int CutNumber()
// {
//     Console.WriteLine("Введите трехзначное число: ");
//     int numThree = int.Parse(Console.ReadLine());
//     Console.WriteLine("число = " + numThree);
//     int result = numThree / 10 % 10;
//     return result;
// }
// int number = CutNumber();
// Console.WriteLine("вторая цифра числа = " + number);


//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int CutNumber()
// {
//     Console.WriteLine("Введите трехзначное число: ");
//     string numThree = Console.ReadLine();                         //Получаем число в строковом значении,чтобы посчитать кол.цифр в числе.
//     int number = int.Parse(numThree);                             //Переводим искомое число к числовому типу.
//     int result = 0;                                               
//     int numLength = numThree.Length;                              //Записали в доп.переменную кол. цифр в числе.
//     if (numLength == 3)                                           //Если кол.цифр = 3,то
//     {
//         result = number % 10;                                     //Результат= деление с остатком на 10
//         Console.WriteLine("третья цифра числа = " + result);
//     }
//     else if (numLength > 3)                                       //Если кол.цифр > 3,то
//     {
//         while (numLength != 3)                                    //Создаем цикл и уменьшаем число до тех пор,пока число не станет 3х значным.
//         {
//                 number=number / 10;
//                 numLength--;
//         }
//           result = number % 10;
//         Console.WriteLine("третья цифра числа = " + result);
//     }
//     else
//     {
//         Console.WriteLine("Третьей цифры нет: ");
//     }
//     return result;
// }
// int number = CutNumber();



// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// string numberStr = String.Empty;                                 // Создание пустой строки
// int number = 0;                                                 
// while (number <= 0 || number >= 8)  {                            // Создали цикл, где на вход принимается число от 0 до 8.Цикл создан для вывода числа от 1 до 7
//     Console.Write("Введите число от 1 до 7: ");
//     numberStr = Console.ReadLine();                             // Запршиваем число и перемещаем в пустую строку
// number = int.Parse (numberStr);                                 // Из строкового значения перевели в числовое
// }
// string[] nameWeek = { "mondey", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" }; // Создаем массив с днем недели

// if (number < 6)
//     Console.WriteLine("будний день" + nameWeek[number - 1]);
// else Console.WriteLine("выходной день" + nameWeek[number - 1]);
// Console.WriteLine (nameWeek[0]);