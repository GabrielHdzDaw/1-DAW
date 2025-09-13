/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 11-11-2024
 * Descripción: Realiza un programa que le pida al usuario 10 frases, las guarde en un array
 *  y tras eso le pedirá al ususario una cadena y deberá sacar aquellas frases que tienen esa 
 * palabra al principio . Por ejemplo:
Introduza 10 frases:
Hola Juan
Juan es rubio
Donde está Juan el rubio?
No sé donde está Juan
...
¿Qué palabra desea buscar?  Juan
El resultado de la búsqueda es:
2.- Juan es rubio 
 * 
 */

using System;
public class CadenaPrincipio
{
	public static void Main()
	{
		string[] frases = new string[10];
		string cadena; 
		
		for (int i = 0; i < frases.Length; i++)
		{
			Console.Write("Introduce una frase ({0} de {1}): ", i + 1, frases.Length);
			frases[i] = Console.ReadLine();
		}
		
		Console.Write("Introduce cadena a buscar: ");
		cadena = Console.ReadLine();
		
		for (int i = 0; i < frases.Length; i++)
		{
			if (frases[i].IndexOf(cadena) == 0)
			{
				Console.WriteLine(frases[i]);
			}
		}
	
	}
}
