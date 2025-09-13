/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-11-2024
 * Descripción: Crea una función Elevar que devuelva el resulado de elevar un
 *  número entero pasado como parámetro por otro entero positivo también pasado como parámetro.

Elevar(2,3) dará como resultado 8.

Se deben utilizar estructuras iterativas.
 * 
 */

using System;
public class ElevarRecursiva
{
	public static int Elevar(int numero, int exponente)
	{
		
		if (exponente == 0)
		{
			return 1;
		}
		return numero * Elevar(numero, exponente - 1);
	}
	public static void Main()
	{
		Console.WriteLine(Elevar(2, 5));
	}
}
