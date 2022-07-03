// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palin(int n)
{
    int[] array = new int[5];
    int index = 4;
    int num = 0;
    while (index > -1)
    {
        num = n % 10;
        array[index] = num;
        n = n / 10;
        index = index - 1;
    }
    if (array[0] == array[4] && array[1] == array[3]) return true;
    else return false;
}
Console.Write("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 10000 || n > 99999)
{
    Console.Write("Число введено неверно");
    return;
}
bool result = Palin(n);
if (result == true) Console.WriteLine("Введённое число является палиндромом");
else Console.WriteLine("Введённое число НЕ является палиндромом");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xLine = x2 - x1;
    double yLine = y2 - y1;
    double zLine = z2 - z1;

    double distQuad = xLine * xLine + yLine * yLine + zLine * zLine;
    double result = Math.Sqrt(distQuad);

    return result;
}

double z1 = 0;
double z2 = 0;

Console.Write("Введите коордитату x для первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коордитату y для первой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коордитату x для второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коордитату y для второй точки ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result1 = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояние между точками равно " + result1);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int n)
{
    int count = 1;
    while (count <= n)
    {
        int squad = count * count * count;
        Console.Write(squad + " ");
        count++;
    }
}

Console.Write("Введите число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Cube(n1);