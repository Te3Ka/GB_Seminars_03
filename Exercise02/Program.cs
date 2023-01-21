/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Написать программу, которая по заданному номеру четверти плоскости
показывает возможный диапазон координат в этой четверти.
*/

int CoordinatesX(int number){
    if ((number == 1) || (number == 4))
        return 1;
    else if ((number == 2) || (number == 3))
        return -1;
    return 0;
}

int CoordinatesY(int number){
    if ((number == 1) || (number == 2))
        return 1;
    else if ((number == 3) || (number == 4))
        return -1;
    return 0;
}

Console.WriteLine("Программа показывает возможный диапазон координат по введённому номеру четверти плоскости.");
Console.Write("Введите номер четверти плоскости: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num != 1) && (num != 2) && (num != 3) && (num != 4)){
    Console.WriteLine($"Введённого номера плоскости {num} не существует. Программа прервана");
    return;
}

int x = CoordinatesX(num);
int y = CoordinatesY(num);

if ((x == 1) && (y == 1))
    Console.WriteLine($"Координаты {num} четверти: X от {x} до плюс бесконечности, Y от {y} до плюс бесконечности");
else if ((x == -1) && (y == 1))
    Console.WriteLine($"Координаты {num} четверти: X от {x} до минус бесконечности, Y от {y} до плюс бесконечности");
else if ((x == -1) && (y == -1))
    Console.WriteLine($"Координаты {num} четверти: X от {x} до минус бесконечности, Y от {y} до минус бесконечности");
else if ((x == 1) && (y == -1))
    Console.WriteLine($"Координаты {num} четверти: X от {x} до плюс бесконечности, Y от {y} до минус бесконечности");