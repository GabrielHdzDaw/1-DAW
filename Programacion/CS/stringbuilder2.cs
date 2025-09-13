/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-11-2024
 * Descripción: Realiza un programa en C# que pida una cadena al usuario y 
 * la enseñe por pantalla pero sustituyendo las vocales por _ (Guiones de subrayado). Por ejemplo:
Hola, ¿Qué tal estás?
H_l_, ¿Q__ t_l _st_s?
 * 
 */

using System;
using System.Text;
public class Test
{
	const string vocales = "aeiouAEIOUáéíóúàèìòùäëïöü";
	public static void Main()
	{
		Console.Write("Introduce una palabra: ");
		string cadena = Console.ReadLine();
		StringBuilder cadenaModificable = new StringBuilder(cadena);
		for (int i = 0; i < cadenaModificable.Length; i++)
		{
			if (vocales.Contains(cadenaModificable[i].ToString()))
			{
				cadenaModificable[i] = '_';
			}
		}
		Console.WriteLine(cadenaModificable.ToString());
	}
}
