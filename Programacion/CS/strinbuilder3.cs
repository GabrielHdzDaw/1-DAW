/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-11-2024
 * Descripción: Crea un programa que le pida al usuario una cadena
 *  y la muestre después con una letra en mayúsculas otra no, así:
Hola como estás
HoLa cOmO eStÁs
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
		for (int i = 0; i < cadenaModificable.Length; i+=2)
		{
			cadenaModificable[i] = Char.ToUpper(cadenaModificable[i]);	
		}
		Console.WriteLine(cadenaModificable.ToString());
	}
}
