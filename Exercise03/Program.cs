/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Написать программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве
A(3, 6); B(2, 1) -> 5,09
A(7, 5); B(1, -1) -> 7,21
*/

double Distance(double ax, double ay, double bx, double by)
{
    return Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));
}

Console.WriteLine("Программа показывает расстояние между двумя точкам на плоскости по введённым координатам.");
Console.Write("Введите координату X точка A = ");
double ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точка A = ");
double ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точка B = ");
double bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точка B = ");
double by = Convert.ToInt32(Console.ReadLine());

double res = Distance(ax, ay, bx, by);

Console.WriteLine($"Расстояние между точками A({ax}, {ay}) и B({bx}, {by}) = {Math.Round(res, 4)}");