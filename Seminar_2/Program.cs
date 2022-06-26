// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
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
void DelSecondNum()
{
    int ran1 = new Random().Next(100, 1000);
    Console.WriteLine("Исходное число " + ran1);

    int first = ran1 / 100;
    int last = ran1 % 10;
    int result = first * 10 + last;

    Console.WriteLine("Итоговое число " + result);
}
DelSecondNum();
Console.WriteLine();

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int remain;

if (num1 % num2 == 0) Console.WriteLine("Второе число кратно первому");
else
{
    remain = num1 % num2;
    Console.WriteLine("Остаток от деления равен " + remain);
}
Console.WriteLine();

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Write("Введите число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num3 % 7 == 0 && num3 % 23 == 0) Console.WriteLine("Введённое число кратно одновременно 7 и 23");
else Console.WriteLine("Введённое число не кратно одновременно 7 и 23");