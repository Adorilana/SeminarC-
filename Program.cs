/* 
19Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число ");
string number = Console.ReadLine();

if (number[0] == number[4] && number[1] == number[3])
{
    Console.Write("число является палиндромом");
} 
else
{
    Console.Write("число НЕ является палиндромом");
}
*/


//21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Console.Write("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");


/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = 1;
while (start <= number)
{
    int result = start * start * start;
    Console.Write(" " + result);
    start++;
}
*/