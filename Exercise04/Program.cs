﻿/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Написать программу, которая принимает на вход число
и выдаёт таблицу квадратов от 1 до этого числа.
5 -> 1, 4, 9, 16, 25
2 -> 1, 4
*/

void Demonstrate(int num)
{
    for (int i = 1; i <= num; i++)
    {
        if(i == N)
            Console.WriteLine(num * num);
        else
            Console.WriteLine(i * i + ", ");
    }
}

Console.WriteLine("Программа показывает числа от 1 до N возведённые в квадрат.");
Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

Demonstrate(N);