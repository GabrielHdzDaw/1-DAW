/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 11-10-2024
 * Descripción: 1. Crea un programa en C# que muestre en pantalla los
 *  números múltiplos de 5 del 50 al -50 (descendiendo),
ambos incluidos, excepto el 15 y el 20, separados por un espacio en blanco, 
de cuatro formas distintas (ninguna
de ellas debe emplear “break” ni continue) (2 puntos):
a) Usando “for” que cuente de 5 en 5
b) Usando “for” que cuente de 1 en 1
c) Usando “do..while”
d) Usando “while”.
 */ 
 


using System;
public class Ejercicio1
{
	public static void Main()
	{
		for(int i = 50; i >= -50; i-=5)
		{
			if(i != 15 && i != 20)
			{
				Console.Write("{0} ", i);
			}
		}
		
		for(int i = 50; i >= -50; i--)
		{
			if(i != 15 && i != 20)
			{
				if(i % 5 == 0)
				{
					Console.Write("{0} ", i);
				}
			}
		}
		
		int i = 0;
		do
		{
			if(i != 15 && i != 20)
			{
				if(i % 5 == 0)
				{
					Console.Write("{0} ", i);
				}
			}
			i++;
		} while (i>=-50);
		
		i = 0;
		while (i>=-50)
		{
			if(i != 15 && i != 20)
			{
				if(i % 5 == 0)
				{
					Console.Write("{0} ", i);
				}
			}
			i++;
		}
		
	}
}
