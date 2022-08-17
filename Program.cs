/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int number = new Random().Next(10,1000);

int result1 = number / 10;
int result2 = result1 % 10;
int result3 = result2 % 10

Console.WriteLine($"Вторая цифра числа {number} - это {result2}");


Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


string number = Console.ReadLine();

Console.WriteLine(number[2]);

Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7) 
{
Console.WriteLine("да");

}

else 
{
Console.WriteLine("нет");
}
