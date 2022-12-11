
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

/*
void showQuad(int quad)
{
    if(quad == 1) Console.WriteLine("x > 0, y > 0");
    else if(quad == 2) Console.WriteLine("x < 0, y > 0");
    else if(quad == 3) Console.WriteLine("x < 0, y < 0");
    else if(quad == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("Такого квадранта нет!");
}

Console.WriteLine("Введите номер квадранта: ");
int cord = Convert.ToInt32(Console.ReadLine());

showQuad(cord);
*/

//Задача 2. Напишите программу которая на вход принимает координат двух точек и находит растояние между ними в 2D пространстве.

/*
double distance(double xA, double xB, double yA, double yB)
{
    double length = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
    return Math.Round(length, 2);

}

Console.Write("Введите X - координату точки A: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X - координату точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y - координату точки A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y - координату точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());

double dB = distance(xA, xB, yA, yB);
Console.WriteLine($"Расстояние между точками А и B равно {dB}");
*/

// Задача 3. Напишите программу которая принимает на вход число и выдает ряд квадр. чмсел от 1 до введенного числа.

/*
void quadNum(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.Write(Math.Pow(counter, 2));
        if (counter != number) Console.Write(", ");
        counter++;
    }
} 
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Серия квадратных чисел: ");
quadNum(num);
*/