﻿// Напишите метод, который принимает на вход три числа и возвращает
// среднее из этих чисел (то есть не самое большое и не самое маленькое).

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if ((a >= b && a <= c) || (a >= c && a <= b))
{
    Console.WriteLine("Среднее число: " + a);
}
else if ((b >= a && b <= c) || (b >= c && b <= a))
{
    Console.WriteLine("Среднее число: " + b);
}
else
{
    Console.WriteLine("Среднее число: " + c);
}