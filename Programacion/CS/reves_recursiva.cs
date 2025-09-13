/*
 * 
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-11-2024
 * Descripción: Crea una función llamada "EscribirAlReves", que muestre al revés un texto recibido como parámetro.
Por ejemplo: EscribeAlReves ("Hola!");  --> "!aloH"
 * 
 */

using System;
public class Test
{
	public static void Reves(string cadena)
	{
		for (int i = cadena.Length - 1; i >= 0 ; i--)
		{
			Console.Write(cadena[i]);
		}
	}
	
	public static void RevesRecursiva(string cadena)
	{
		if (cadena.Length == 1)
		{
			Console.Write(cadena);
		}
		else
		{
			Console.Write(cadena[cadena.Length - 1]);
			RevesRecursiva(cadena.Substring(0, cadena.Length - 1));
		}
	}
	
	public static void Main()
	{
		Reves("Patata");
		Console.WriteLine();
		RevesRecursiva("Patata");
	}
}
