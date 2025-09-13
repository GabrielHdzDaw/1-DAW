/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 08-11-2024
 * Descripción: Crea un programa en C# que pida un texto al usuario y compruebe 
 * si está todo en mayúsculas. Si es así se debe poner todo en minúsculas excepto la primera posición 
 * que continuará en mayúsculas. (Utiliza una función para realizar la manipulación de la cadena)
 * 
 */

using System;
public class CadenasComprobarMayus
{
	public static void Main()
	{
		string cadena, cadenaFinal = "";
		
		Console.Write("Introduce una cadena: ");
		cadena = Console.ReadLine();
		
		if (cadena == cadena.ToUpper())
		{
			cadenaFinal = cadena[0] + cadena.Substring(1).ToLower();
			Console.WriteLine(cadenaFinal);
		}
		else
		{
			Console.WriteLine(cadena);
		}
		
	}
}
