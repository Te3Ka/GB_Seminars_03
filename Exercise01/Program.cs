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

int WhichQuarterPlane(int x, int y)
{
    if ((x > 0) && (y > 0))
        return 1;
    else if ((x < 0) && (y > 0))
        return 2;
    else if ((x < 0) && (y < 0))
        return 3;
    else if ((x > 0) && (y < 0))
        return 4;
    return -1; 
}

Console.WriteLine("Программа показывает четверть плоскости, которой принадлежит введённая точка.");
Console.Write("Введите координату X = ");
int x = Convert.ToInt32(Console.ReadLine());
int corrX = CorrectCoordinates(x);
Console.Write("Введите координату Y = ");
int y = Convert.ToInt32(Console.ReadLine());
int corrY = CorrectCoordinates(y);

if ((corrX == -1) || (corrY == -1))
{
    Console.WriteLine("Введены неверные координаты. Программа прервана.");
    return;
}

int result = WhichQuarterPlane(x, y);

Console.WriteLine($"Точка с координатами ({x}, {y}) принадлежит четверти № {result}");
//Console.Write("Точка принадлежит координатной плоскости № ");
//Console.WriteLine(WhichQuarterPlane(x, y));