/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 26-11-2024
 * Descripción: Crea una función llamada CambiaLetra que modifique la letra de una determinada
 *  posición (empezando desde 0) de una cadena y la reemplazará por otro carácter. Realiza 
 * un programa que pida datos al usuario para probarla.

string frase = "Tomate";
CambiaLetra(ref frase, 5, 'a');
// Ahora la frase será "Tomata"
 * 
 */

using System.Text;
using System;
public class CambiarLetrasRef
{
	public static void CambiaLetra(ref StringBuilder cadena, int posicion, char letra)
	{
		cadena[posicion] = letra;
	}
	public static void Main()
	{
		StringBuilder cadena = new StringBuilder("Ronaldinho Soccer");
		Console.Write("Introduce la posición a cambiar: ");
		int posicion = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce la letra: ");
		char letra = Convert.ToChar(Console.ReadLine());
		
		CambiaLetra(ref cadena, posicion, letra);
		
		Console.WriteLine(cadena);
	}
}
