// ДЗ к семинару № 3

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 9999 && num < 100000)
// {
//     int n1 = num / 1000;
//     int n2 = num % 100;
//     int revers = n1 % 10 * 10 + n1 / 10;
//     if (revers == n2)
//         Console.WriteLine("Это число палиндром");
//     else
//         Console.WriteLine("Это число не палиндром");
// }
// else Console.WriteLine("Введенное число не пятизначное");



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Rast (double xA, double yA, double zA, double xB, double yB, double zB)
// {
//     double result = Math.Sqrt(Math.Pow(xB - xA,2) + Math.Pow(yB - yA,2) + Math.Pow(zB - zA,2));
//     return result;
// }
// Console.Write("Введите координату xA: ");
// double xA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату yA: ");
// double yA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату zA: ");
// double zA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату xB: ");
// double xB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату yB: ");
// double yB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату zB: ");
// double zB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Round(Rast(xA, yA, zA, xB, yB, zB),2));



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int nv3 = 1; nv3 <= n; nv3++)
// {
//     Console.WriteLine(nv3 +" - " +Math.Pow(nv3,3));
// }



// ДЗ к семинару № 4

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Stepen(int a, int b)
// {
// int res = 1;
// for (int i = 1; i <= b; i++)
// {
//     res = res*a;
// }
// return res;
// }
// Console.Write("Введите число a = ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число b = ");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = Stepen(a,b);
// Console.WriteLine("Число a в степени b = " +result);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Summa(int n)
// {
//     int s = 0;
//     while (n > 0)
//     {
//         s = s + n%10;
//         n = n/10;
//     }
//     return s;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = Summa(num);
// Console.WriteLine("Сумма цифр этого числа: "+result);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] RandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void WriteArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный элемент массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный элемент массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = RandomArray(length, min, max);
// WriteArray(myArray);
