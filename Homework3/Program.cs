/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

using System;
class Program
{
static void Main(string[] args)
	{
		Console.Write("Введите целое натуральное число n = ");
		int n = Convert.ToInt32(Console.ReadLine());
	
		int index = 1;

		while (index < n)
		{
			Console.Write(Math.Pow(index,3.0) + ", ");
			index++;
		}
		Console.Write(Math.Pow(index,3.0) + ". ");
	}
}





