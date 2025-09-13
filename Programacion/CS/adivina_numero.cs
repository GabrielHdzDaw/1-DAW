/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 30-09-2024
 * Descripción: Haz un programa que dé al usuario la oportunidad de adivinar un número del 1 al 100 (prefijado en el 
 * programa) en un máximo de 6 intentos. En cada pasada deberá avisar de si se ha pasado o se ha quedado corto
 */ 
 


using System;
public class AdivinaNumero
{
	public static void Main()
	{
		int numero, intentos = 0, objetivo = 42;
		
		do
		{
			Console.Write("Adivina el número: ");
			numero = Convert.ToInt32(Console.ReadLine());
			if (intentos < 6 && numero != objetivo)
			{
				if (numero > objetivo)
				{
					Console.WriteLine("Te has pasado.");
				}
				else
				{
					Console.WriteLine("Te has quedado corto.");
				}
				intentos++;
			}
		}while(numero != objetivo && intentos < 6);
		
		Console.WriteLine(numero == objetivo ? "¡Lo conseguiste!" : "Te has quedado sin intentos.");
}
}
