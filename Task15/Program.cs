﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели  - ");
int number = Convert.ToInt32(Console.ReadLine()); 

if (number <= 7)
{
    if (number <=5)
     {
        Console.WriteLine($"Этот день не является выходным.");
     }
    else 
     {
        Console.WriteLine($"Этот день является выходным.");
     }
}
else
{
    Console.Write($"Вы ввели не правильную цифру ");
}

  