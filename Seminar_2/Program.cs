// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Первая задача");

void ShowBiggerDigit()
{
    int rand = new Random().Next(10, 100);
    Console.WriteLine("Our current number " + rand);

    int dec = rand / 10;
    int ed = rand % 10;
    int max;
    if (dec > ed) max = dec;
    else max = ed;

    Console.WriteLine("Bigger digit is " + max);
}
ShowBiggerDigit();
Console.WriteLine();

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Console.WriteLine("Вторая задача");

int DelSecondNum()
{
    int ran1 = new Random().Next(100, 1000);
    Console.WriteLine("Исходное число " + ran1);

    int first = ran1 / 100;
    int last = ran1 % 10;
    int result = first * 10 + last;

    return result;
}
int res1 = DelSecondNum();
Console.WriteLine("Итоговое число " + res1);
Console.WriteLine();

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
Console.WriteLine("Третья задача");

// Первый вариант
Console.WriteLine("Первый вариант");

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int remain;

if (num2 % num1 == 0) Console.WriteLine("Второе число кратно первому");
else
{
    remain = num2 % num1;
    Console.WriteLine("Остаток от деления равен " + remain);
}
Console.WriteLine();

// Второй вариант
Console.WriteLine("Второй вариант");

int RemainNum(int b1, int b2)
{
    if (b2 % b1 == 0)
    {
        Console.WriteLine($"{b2} кратно {b1}");
        return 0;
    }
    else
    {
        int remain1 = b2 % b1;
        return remain1;
    }
}
Console.Write("Введите первое число: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b2 = Convert.ToInt32(Console.ReadLine());
int res2 = RemainNum(b1, b2);
if (res2 != 0) Console.WriteLine($"{b2} и {b1} не делятся! Остаток = {res2}");
Console.WriteLine();

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Четвёртая задача");

// Первый вариант
Console.WriteLine("Первый вариант");

Console.Write("Введите число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num3 % 7 == 0 && num3 % 23 == 0) Console.WriteLine("Введённое число кратно одновременно 7 и 23");
else Console.WriteLine("Введённое число не кратно одновременно 7 и 23");
Console.WriteLine();

// Второй вариант
Console.WriteLine("Второй вариант");

bool DivisibleBothNum (int r)
{
    if (r % 7 == 0 && r % 23 == 0) return true;
    else return false;
}
Console.Write("Введите число: ");
int r = Convert.ToInt32(Console.ReadLine());

bool res3 = DivisibleBothNum(r);
Console.WriteLine(res3);