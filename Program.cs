// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень B ");
int powerB = Convert.ToInt32(Console.ReadLine());
int number = 1;
for (int i = 1; i <= powerB; i++)
{
    number *= numberA;
}
Console.WriteLine(number);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (x > 0)
{
    sum += x % 10;
    x = (x - x % 10) / 10;
}
Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}

Console.WriteLine($"Результат: [ {String.Join("; ", array)} ]");

// или так
// int[] GetArray (int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
//     return array;
// }
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// int[] resultArray = GetArray(sizeArray);
// Console.WriteLine($"Результат: [ {String.Join("; ", resultArray)} ]");
