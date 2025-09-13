/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 07-11-2024
 * Descripción: Pide al usuario una frase y muéstrala después con espacios
 *  en blanco entre letras. Por ejemplo si el usuario introduce "Hola", se debe mostrar "H o l a". 
 * 
 */

using System;
public class ManipulacionStringsEspacios
{
	public static void Main()
	{
		string cadena;
		string resultado = "";
		Console.Write("Introduce una cadena: ");
		cadena = Console.ReadLine();
		
		
		for (int i = 0; i < cadena.Length; i++)
		{
			resultado += cadena[i] + " ";
		}
		
		Console.WriteLine(resultado);
	}
}
