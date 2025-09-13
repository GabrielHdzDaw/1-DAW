/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 01-10-2024
 * Descripción: Escribe un programa que muestre  todos los números enteros positivos menores que
 *  1000 que son múltiplos de 3 o de 5, pero no de ambos.
 */ 
 


using System;
public class DivisoresExclusivos
{
	public static void Main()
	{
		for(int i = 1; i < 1000; i++)
		{
			if(!(i % 3 == 0 && i % 5 == 0) && (i % 3 == 0 || i % 5 == 0))
			{
				Console.Write("{0} ", i);
			}
		}
	}
}
