// Задача 66: Задайте значения m и n. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от m до n.
/*
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSum(m, n, temp=0);

void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  PrintSum(m, n - 1, sum);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"А(m,n) = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
*/

// Задача 64: Задайте значения m и n. Напишите программу, которая выведет все натуральные числа в промежутке от m до n.

Console.Write("Введиnt m: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt16(Console.ReadLine());

if (n>m)
for (int i = m; i <= n; i++)
    Console.Write($" {i}");
else
    for (int i = n; i <= m; i++)
        Console.Write($" {i}");