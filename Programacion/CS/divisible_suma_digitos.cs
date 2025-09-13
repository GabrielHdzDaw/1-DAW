/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 26-09-2024
 * Descripción: Escribe un programa que muestre los números enteros
 *  del 1 al 100 que son divisibles por la suma de sus dígitos.
 */ 
 


using System;
public class DivisibleSumaDigitos
{
	public static void Main()
	{
		int numero, suma = 0, resto = 0;
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		do
		{
			resto = numero%10;
			suma += resto;
			numero = numero/10;
		} while(numero != 0);
		
		for(int i = 1; i<= 100; i++)
		{
			if (i % numero == 0)
			{
				Console.WriteLine("{0} es divisible entre {1}", i, numero);
			}
		}
	}
}
