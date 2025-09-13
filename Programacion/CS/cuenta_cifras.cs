/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 26-09-2024
 * Descripción: Crea un programa en C# que dado un número sumininstrado por el 
 * usuario, responda el número de sus dígitos. Se deben averiguar dividiendo entre 10 sucesivamente.

 */ 
 


using System;
public class CuentaDigitos
{
	public static void Main()
	{
		int numero, dividido, i = 0;
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		dividido = numero;
		for(i = 1; dividido >= i; i++)
		{
			dividido = dividido / 10;
		}
		Console.WriteLine("Cifras de {0}: {1}", numero, i);
	}
}
