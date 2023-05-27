// ДЗ к семинару № 1

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
//     Console.WriteLine("max = " +num1);
// else if (num1 == num2)
//     Console.WriteLine("Вы ввели одинаковые числа");
// else
//     Console.WriteLine("max = " +num2);



// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// Console.WriteLine("max = " +max);



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
//     Console.WriteLine("Число четное");
// else 
//     Console.WriteLine("Число нечетное");




// Задача 8: Напишите программу, которая на вход принимает число (N), 
// на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.Write("Введите целое положительное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = 1;
// while (n1 <= n)
// {
//     if (n1 % 2 == 0)
//     {
//         Console.Write(n1 + " ");
//     }
//     n1 = n1 + 1;
// }


// ДЗ к семинару № 2



// ДЗ к семинару № 3

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
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
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
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

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
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

/*
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный возможный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный возможный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomArray(length, min, max);
WriteArray(myArray);
*/


// ДЗ к семинару № 5

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int [] FillArray(int size)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach(int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int FindCount(int[] array)
{
    int count = 0;
    foreach(int item in array)
    {
        if(item%2 == 0) count++;
    }
    return count;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = FillArray(length);
PrintArray(myArray);
int rez = FindCount(myArray);
Console.WriteLine("Количество четных чисел в массиве: " +rez);
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void PrintArray(int[] array)
{
foreach(int item in array)
Console.Write($"{item} ");
Console.WriteLine();
}

int Summa(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    sum = sum + array[i];
    return sum;
}

int[] array = new int[6];
FillArray(array);
PrintArray(array);
int rez = Summa(array);
Console.WriteLine("Сумма элементов с нечетным индексом = " +rez);
*/


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble();
    return array;
}

void PrintArray(double[] array)
{
    foreach (double item in array) 
        Console.Write($"{item:F2}  "); 
    Console.WriteLine();
}

double FindRasn(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double rasn = max - min;
    return rasn;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] myArray = FillArray(length);
PrintArray(myArray);
double result = FindRasn(myArray);
Console.WriteLine($"Разница между макс и мин элементами массива = {result:F2}");
*/



// ДЗ к семинару № 6

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
Console.Write("Сколько чисел будете вводить? ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 0; i < n; i++)
{
    Console.Write("Введите целое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > 0)  count++;
}
Console.WriteLine($"Вы ввели {count} положительных чисел");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = (b2 - b1)/(k1 - k2);
double y = k1*x + b1;
Console.WriteLine($"Точка пересечения ({x};{y})");
*/
