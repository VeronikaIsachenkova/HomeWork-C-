// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// Console.Clear();
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// PrintNumber(n, m);


// void PrintNumber(int n, int m)
// {
//   if (m > n) return;
//   Console.Write(m + ",");
//   PrintNumber(n, m + 1);
 
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int temp = m;

// if (m > n) 
// {
//   m = n; 
//   n = temp;
// }

// PrintSum(m, n, temp=0);

// void PrintSum(int m, int n, int sum)
// {
//   sum = sum + n;
//   if (n <= m)
//   {
//     Console.Write($"Сумма элементов = {sum} ");
//     return;
//   }
//   PrintSum(m, n - 1, sum);
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// Console.Clear();
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");

// int functionAkkerman = Akkerman(m, n);

// Console.Write($"Функция Аккермана = {functionAkkerman} ");

// int Akkerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Akkerman(m - 1, 1);
//   else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }