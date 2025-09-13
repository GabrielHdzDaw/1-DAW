/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 28-11-2024
 * Descripción: Vamos a realizar una función void llamada ApropiadaCadena que se le
 *  pasará una cadena por referencia y la devolverá en minísculas excepto 
 * la primera en mayúscula y si hay algún punto, el carácter de después del punto también en mayúsculas.
 *  
 */

using System;
public class CadenaApropiada
{
	public static void ApropiadaCadena(ref string cadena)
	{
		string[] cadenas = cadena.Split('.');
		for (int i = 0; i < cadenas.Length; i++)
		{
			for (int j = 0; j < cadenas[i].Length; j++)
			{
				if (i == 0)
				{
					char letra = cadenas[i][j];
					cadenas[i] = cadenas[i].Remove(j);
					cadenas[i] = cadenas[i].Insert(j, letra);
				}
				
			}
		}
		
	}
	
	public static void Main()
	{
		string cadena = "hola caracola.que mañana hay cocacola";
		ApropiadaCadena(ref cadena);
	}
}
