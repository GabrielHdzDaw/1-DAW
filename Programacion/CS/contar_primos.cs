/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 30-09-2024
 * Descripción: Crea un programa en C# que nos diga cuántos números primos 
 * hay hasta un número suministrado por el usuario.

Por ejemplo:

Introduzca un número: 10

Los primos hasta 10 son: ,2,3,5,7,
 */ 
 


using System;
public class ContarPrimos
{
	public static void Main()
	{
		int numero, divisores = 0;
		do
		{
			Console.Write("Introduce un número: ");
			numero = Convert.ToInt32(Console.ReadLine());
		}while(numero < 1);
		
		Console.Write("Los primos hasta {0} son: ", numero);
		for(int i = 2; i <= numero; i++)
		{
			divisores = 0;
			for(int j = 2; j < i; j++)
			{
				if(i % j == 0)
				{
					divisores++;
				}
				
			}
			Console.Write(divisores == 0 ? "{0}, " : "", i);
		}
	}
}
