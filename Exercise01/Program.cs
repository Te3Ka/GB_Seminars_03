/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
при чём X != 0 и Y != 0 и выдаёт номер четверти плоскости, в которой находится точка. 
*/

int CorrectCoordinates(int coordinate)
{
    if (coordinate != 0)
        return 1;
    else
        return -1;
}

Console.WriteLine("Программа показывает четверть плоскости, которой принадлежит введённая точка.");
Console.Write("Введите координату X = ");
int x = Convert.ToInt32(Console.ReadLine());
int corrX = CorrectCoordinates(x);
Console.Write("Введите координату Y = ");
int y = Convert.ToInt32(Console.ReadLine());
int corrY = CorrectCoordinates(y);

if ((x == -1) && (y == -1))
{
    Console.WriteLine("Введены неверные координаты. Программа прервана.");
    return;
}

