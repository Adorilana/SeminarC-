﻿/*
25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);

 27  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
  

  Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int Sum(int numberN)
  {
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = Sum(numberN);
Console.WriteLine("Сумма: " + sumNumber);

29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/


int[] GetBinaryArray(int size)
{
int[] result = new int[size]; 
for (int i = 0; i < result.Length; i++) 
{
result[i] = new Random().Next(100); 
}
return result;
}
int[] testArray = GetBinaryArray(8);
Console.WriteLine($"Массив: [ {String.Join(", ",testArray)} ]");