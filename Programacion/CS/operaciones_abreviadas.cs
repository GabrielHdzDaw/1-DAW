/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-10-2024
 * Descripción: Crea un programa que pregunte al usuario 3 números enteros y enseñe:
-- el primero incrementado
-- el segundo dividido entre 3
-- el tercero decrementado en 5
 */ 
 


using System;
public class OperacionesAbreviadas
{
	public static void Main()
	{
		int numero1, numero2, numero3;
		Console.Write("Introduce un número: ");
		numero1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		numero2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		numero3 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine(numero1++);
		Console.WriteLine(numero2 /= 3);
		Console.WriteLine(numero3 -= 5);
	
}
}
