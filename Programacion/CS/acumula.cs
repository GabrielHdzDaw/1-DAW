/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 23-09-2024
 * Descripción:Realiza un programa de C# que pedirá un número si no es cero,
 *  pedirá otro y sacará su suma y seguirá pidiendo números y sacando la 
 * suma de ese número más todos los anteriores hasta que se introduzca un 0.
 * 
 */

using System;
public class Acumula
{
	public static void Main()
	{
		int numero, suma;
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		suma = numero;
		while(numero != 0)
		{
			Console.Write("Introduce otro número: ");
			numero = Convert.ToInt32(Console.ReadLine());
			if (numero != 0)
			{
				suma += numero;
				Console.WriteLine(suma);
			}
		}
	}
}
