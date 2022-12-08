
/*
int firdQuadrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Ввудите X координату: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y координату: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadNum = firdQuadrant(xA, yA);

Console.WriteLine($"Точка A({xA}, {yA}) находиться в квадранте {quadNum}");
*/

//Задача 1. Напишите программу которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти.

void showQuad(int quad)
{
    if(quad == 1) Console.WriteLine("x > 0, y > 0");
}
