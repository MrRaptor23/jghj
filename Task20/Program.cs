﻿//Задача 20: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите координаты двух точек");
int numX1 = Convert.ToInt32(Console.ReadLine()); 
int numY1 = Convert.ToInt32(Console.ReadLine()); 
int numX2 = Convert.ToInt32(Console.ReadLine()); 
int numY2 = Convert.ToInt32(Console.ReadLine()); 
double Distance (int x1 , int y1 ,int x2 , int y2 )
{
return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));


}
//Math.Pow(2, 10);
//double d = 5.09998774;
//double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
//Console.WriteLine(dRound);