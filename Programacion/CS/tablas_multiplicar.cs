/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 03-10-2024
 * Descripción: Pide al usuario dos números y escribe las tablas de multiplicar desde el primer número hasta el segundo.
 *  (Suponemos que el usuario ha puesto primero el menor y después el mayor)
 */ 
 


using System;
public class Multiplicar
{
	public static void Main()
	{
		int numero1, numero2;
		Console.Write("Introduce un número: ");
		numero1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		numero2 = Convert.ToInt32(Console.ReadLine());
		
		
		
		for (int i = numero1; i <= numero2; i++)
		{
			for (int j = 0; j <= 10; j++)
			{
				Console.WriteLine("{0} x {1} = {2}", i, j, i*j);
			}
			Console.WriteLine("-------------");
		}
		
	}
}
