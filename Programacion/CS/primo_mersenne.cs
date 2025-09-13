/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 25-10-2024
 * Descripción: Un número de Mersenne es un número entero positivo M que es una unidad 
 * menor que una potencia entera positiva de 2: 

{\displaystyle M_{n}=2^{n}-1.}

Realiza un programa que diga si un número introducido por el usuario es un número de Mersenne.

Por tanto las condiciones son:

1.- Número entero

2.- Número positivo

3.- Una unidad menor que una potencia de 2 (hay que averiguar qué potencia de 2, se van 
probando potencias de 2 hasta que nos pasemos del número estudiado)
 * 
 */

using System;
public class PrimoMersenne
{
	public static void Main()
	{
		int numero;
		Console.WriteLine("Introduce un número entero positivo: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		if (numero > 0)
		{
			
			int i = 1;
			while (Math.Pow(i, 2) <= numero)
			{
				if (numero == Math.Pow(2, i) - 1 && numero % i != 0)
				{
					Console.Write("{0} es primo de mersenne", numero);
				}
				i++;
			}
		}
	}
}
