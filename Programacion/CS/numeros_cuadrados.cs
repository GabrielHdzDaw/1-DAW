/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 24-09-2024
 * Descripción: Realiza un programa en C# que a saque por pantalla los primeros 
 * n números cuadrados, siendo n un número proporcionado por el usuario.
	Por ejemplo si se introduce el número 4 el programa sacaría: 1, 4, 9, 16
 * 
 */

using System;
public class NumerosCuadrados
{
	public static void Main()
	{
		int numero;
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		for(int i = 1; i <= numero; i++)
		{
			Console.Write(i == numero ? "{0}": "{0}, ", i*i);
		}
	}
}
