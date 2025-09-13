/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 25-11-2024
 * Descripción: Realizar una función llamada public static string Desplazar(string frase, posiciones) 
 *  que sustituya cada letra de frase por la letra desplazada el número de posiciones indicado en posiciones. Devolverá
 *  esta nueva frase encriptada de esta forma.
Por ejemplo si la frase es: Hola Mari Chelo. El resultado sería: krod pdul fkhor. (Lo pasamos todo en minúsculas)
Teniendo en cuenta que al llegar a la z se empieza de nuevo por la a.
Podéis apoyaros en otra función que se llame public static char Desplazar(char letra, posiciones) que devuelva cada
letra desplazada correctamente.
 * 
 */

using System;
public class Desplazamiento
{
	public static string Desplazar(string cadena, int posiciones)
	{
		cadena = cadena.ToLower();
		string nuevaCadena = "";
		for (int i = 0; i < cadena.Length; i++)
		{
			if(cadena[i] != ' ')
			{
				nuevaCadena += Desplazar(cadena[i], posiciones);
			}
			else
			{
				nuevaCadena += ' ';
			}
		}
		return nuevaCadena.ToLower();
	}
	
	public static char Desplazar(char letra, int posiciones)
	{
		int valorLetra = Convert.ToInt32(letra);
		int nuevoValorLetra = valorLetra + posiciones;
		char nuevaLetra = Convert.ToChar(nuevoValorLetra);
		if (nuevaLetra + posiciones > 122)
		{
			nuevaLetra = Convert.ToChar(nuevaLetra + posiciones - 122 + 97);
		}
		else
		{
			nuevaLetra = Convert.ToChar(nuevaLetra + posiciones);
		}
		
		return nuevaLetra;
	}
	public static void Main()
	{
		Console.WriteLine(Desplazar("Gorilas en la mar", 1));
	}
}
