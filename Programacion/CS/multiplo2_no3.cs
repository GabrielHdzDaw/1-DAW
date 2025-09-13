/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17-09-2024
 * Descripción: Crea un programa que pida al usuario un número entero y responda si es
	múltiplo de 2 pero no de 3.
	
 * 
 */

using System;
public class MultiploDe2No3
{
	public static void Main()
	{
		int num, multiplo;
		Console.Write("Introduce un número: ");
		num = Convert.ToInt32(Console.ReadLine());
		multiplo = num % 2 == 0 && !(num % 3 == 0) ? 1 : 0;
		Console.WriteLine(multiplo == 1 ? "Es múltiplo de 2 pero no de 3" : "Es múltiplo de 2 o 3");
				
	}
}
