// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuart(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return -1;
}

Console.Write("Input x coordinate: ");
int x0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y coordinate: ");
int y0 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Num of current quart is " + FindQuart(x0, y0));

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void Range(int n)
{
    if (n == 1) Console.Write("Диапозон возможных точек (x > 0; y > 0)");
    if (n == 2) Console.Write("Диапозон возможных точек (x < 0; y > 0)");
    if (n == 3) Console.Write("Диапозон возможных точек (x < 0; y < 0)");
    if (n == 4) Console.Write("Диапозон возможных точек (x > 0; y < 0)");
    if (n < 1 || n > 4) Console.Write("Такой четверти не существует");
}

Console.Write("Введите номер четверти ");
int n = Convert.ToInt32(Console.ReadLine());
Range(n);

// Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.

void Grade(int n)
{
    int count = 1;
    while (count <= n)
    {
        int squad = count*count;
        Console.Write(squad + " ");
        count++;
    }
}

Console.Write("Введите число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Grade(n1);

// Найти длину гиппотенузы в трёхмерном пространстве

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xLine = x2 - x1;
    double yLine = y2 - y1;
    double zLine = z2 - z1;

    double distQuad = xLine*xLine + yLine*yLine + zLine*zLine;
    double result = Math.Sqrt(distQuad);

    return result;
}