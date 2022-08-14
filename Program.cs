/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


Console.Write("Введите число №1: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №2: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber) 
{
Console.WriteLine(firstNumber);
}

else 
{
Console.WriteLine(secondNumber);
}

Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число №1: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber %2==0) 
{
Console.WriteLine(firstNumber + " является четным ");

}

else 
{
Console.WriteLine(firstNumber + " НЕ является четным ");
}

