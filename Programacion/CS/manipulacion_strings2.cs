/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 08-11-2024
 * Descripción: Pide al usuario una frase y muéstrala después al revés. 
 * Por ejemplo, si el usuario introduce "Hola", mostrarás "aloH".
 * 
 */

using System;
public class ManipulacionStrings2
{
	public static void Main()
	{
		string cadena;
		Console.Write("Introduce una cadena: ");
		cadena = Console.ReadLine();
		
		for (int i = cadena.Length - 1; i >= 0; i--)
		{
			Console.Write(cadena[i]);
		}
	}
}
