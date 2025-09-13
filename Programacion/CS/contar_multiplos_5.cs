/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 01-10-2024
 * Descripción: Realiza un programa en C# que pida números al usuario hasta que este introduzca un 0. Deberá contar
 *  los que son múltiplos de 5 y el 0 final no debe ser contado
 */ 
 


using System;
public class ContarMultiplos5
{
	public static void Main()
	{
		int numero = 1, contador = 0;
		while(numero != 0)
		{
			Console.Write("Introduce un número: ");
			numero = Convert.ToInt32(Console.ReadLine());
			
			if(numero != 0 && numero % 5 == 0)
			{
				contador++;
			}
		}
		Console.WriteLine(contador > 0 ? "{0} múltiplos de 5" : "Ningún múltiplo de 5", contador);
	}
}
