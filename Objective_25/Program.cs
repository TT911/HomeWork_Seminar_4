﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число А: ");
int numA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int numB = int.Parse(Console.ReadLine()!);

int total = 1;

Console.WriteLine($"{numA}, {numB} -> {calc(total)}");

int calc (int step)
    {
        for (int i = 1; i <= numB; i++)
        {
            total = numA * total;
        }
    
return total;
    }
