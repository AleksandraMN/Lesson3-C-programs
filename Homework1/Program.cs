/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
 */

using System;
class Program
{
	static int Palindrom(int arg)
	{
		int number = arg, result = 0;
		int position1 = (arg / 10000) % 10, position5 = arg % 10; 
		int position2 = (arg / 1000) % 10, position4 = (arg / 10) % 10;
		if(arg >= 10000 && arg < 100000) 
		{
			if(position1 == position5 && position2 == position4) 
			{
				result = 1; 
			}
			else 
			{
				result = -1;
			}
		}
		return result;
	
	}

		static void AnyNumber()
		{
			Console.Write("Введите целое натуральное пятизначное число: ");
			int number = Convert.ToInt32(Console.ReadLine());
			int index = Palindrom(number);
			if (index == 1) Console.WriteLine("Да, число является палиндромом.");
			if (index == 0) Console.WriteLine("Вы не ввели заданное число!");
			if (index == -1) Console.WriteLine("Нет, число не является палиндромом."); 
		}		
		
		static void Main(string[] args)
		{
			AnyNumber();
		}

	}



