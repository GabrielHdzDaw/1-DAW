/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-11-2024
 * Descripción: Realiza un programa en C# que pida una cadena al usuario y
 *  la enseñe por pantalla pero sustituyendo por asteriscos una posición de cada 3. Por ejemplo:
Hola, ¿Qué tal estás?
Ho*a, *Qu* t*l *st*s?
 * 
 */

using System;
using System.Text;
public class Test
{
	public static void Main()
	{
		Console.Write("Introduce una palabra: ");
		string cadena = Console.ReadLine();
		StringBuilder cadenaModificable = new StringBuilder(cadena);
		for (int i = 2; i < cadenaModificable.Length; i+=3)
		{
			cadenaModificable[i] = '*';
		}
		Console.WriteLine(cadenaModificable.ToString());
	}
}
