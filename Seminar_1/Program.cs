// Console.WriteLine("My number is " + number + " and it is good!")
// Console.WriteLine($"My number is {number} and it is good!");
// number = Convert.ToInt32(Console.ReadLine());


// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

int number;
string weekday = "Wrong number"; 

Console.Write("Input a number from 1 to 7: ");
number = Convert.ToInt32(Console.ReadLine());

if (number == 1) weekday = "Mondey";
if (number == 2) weekday = "Tuesday";
if (number == 3) weekday = "Wednesday";
if (number == 4) weekday = "Thursday";
if (number == 5) weekday = "Friday";
if (number == 6) weekday = "Saturday";
if (number == 7) weekday = "Sunday";

Console.WriteLine($"This is {weekday}");

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

int number;
int numLast; 

Console.Write("Введите трёхзначное число: ");
number = Convert.ToInt32(Console.ReadLine());

numLast = number % 10;
Console.WriteLine($"Последняя цифра {numLast}");