/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-10-2024
 * Descripción: Realiza un programa en C# que obtenga los valores de la siguiente función:

y = x2 - 2x + 1

x irá desde -10 a 10 (entero)

Deben salir los datos de la siguiente forma:

x=-10  y=121

x=-9   y=100

...
 */ 
 


using System;
public class ValoresFuncion
{
	public static void Main()
	{
		for(int i = -10; i <= 10; i++)
		{
			Console.WriteLine("x = {0}  y = {1}", i, i*i - 2*i + 1);
		}
	}
}
