// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int positiveNum(int num)
{
    int count = 0;
    int sum = 0;
    while (count < num)
    {
        Console.Write("Введите число и нажмите Enter: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0) sum++;
        count++;
    }
    return sum;
}

Console.WriteLine("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество чисел больше нуля равно {positiveNum(M)}");

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
    for (int i = 0; i < coeff.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < coeff.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            coeff[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] coeff)
{
    crossPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    crossPoint[1] = crossPoint[0] * coeff[0, 0] + coeff[0, 1];
    return crossPoint;
}

void Intersection(double[,] coeff)
{
    if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1]) Console.Write($"Прямые совпадают");
    else if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1]) Console.Write($"Прямые параллельны");
    else
    {
        Decision(coeff);
        Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputCoefficients();
Intersection(coeff);