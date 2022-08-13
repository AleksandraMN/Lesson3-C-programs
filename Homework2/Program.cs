/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


using System;
class Program
{
static int FillArray(int [] args)
{	
	Console.Write("Введите координату - ");
	return Convert.ToInt32(Console.ReadLine());
}

static void Main(string[] args)
	{
		int [] A = new int[3];
		Console.WriteLine("Введите координаты точки A: ");
		A[0] = FillArray(A);
		A[1] = FillArray(A);
		A[2] = FillArray(A);
		int [] B = new int[3];
		Console.WriteLine("Введите координаты точки B: ");
		B[0] = FillArray(B);
		B[1] = FillArray(B);
		B[2] = FillArray(B);
		double S = Math.Round(Math.Sqrt(Math.Pow((B[0]-A[0]),2.0) + Math.Pow((B[1]-A[1]),2.0) + Math.Pow((B[2]-A[2]),2.0)),2);
		Console.Write("Расстояние между точками А и В в 3D пространстве равно: " + S + ".");
	}
}






